using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryManagementSystem.DAO {
    public class BookService : IBookDAO {
        public bool Create(BookModel book) {
                SqlConnection connection = DatabaseConnectionHelper.GetConnection();
                string sql = $"Insert into book values('{book.Id}','{book.ISBN}','{book.Name}','{book.AuthorName}','{book.Category}',{book.UnitPrice},'{book.PublishedAt}','{book.PublisherName}','{book.Volume}')";
                SqlCommand command = new SqlCommand(sql, connection);
                int result=command.ExecuteNonQuery();
                if (result > 0) 
                    return true;
            return false;
        }

        public bool Delete(string Id) {
            SqlConnection connection = DatabaseConnectionHelper.GetConnection();
            string sql = $"delete from book where Id='{Id}'";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            if (result > 0)
                return true;
            return false;
        }

        public List<BookModel> GetAll() {
           SqlConnection connection= DatabaseConnectionHelper.GetConnection();
            string sql = "select * from book";
            SqlCommand cmd=new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<BookModel> books=new List<BookModel>();
            while (reader.Read()) {
                BookModel book = new BookModel();
                book.Id = reader["Id"].ToString();
                book.Name= reader["Name"].ToString();
                book.ISBN = reader["ISBN"].ToString();
                book.UnitPrice =Convert.ToDecimal( reader["UnitPrice"]);
                book.AuthorName = reader["AuthorName"].ToString();
                book.PublisherName = reader["PublisherName"].ToString();
                book.Category = reader["Category"].ToString();
                book.Volume = reader["Volume"].ToString();
                book.PublishedAt =Convert.ToDateTime(reader["PublishedAt"].ToString());
                //collecting the book in books list object 
                books.Add(book);
            }//end of while 
            return books;
        }

        public bool Update(BookModel book) {
            SqlConnection connection = DatabaseConnectionHelper.GetConnection();
            string sql = $"update book set ISBN='{book.ISBN}',Name='{book.Name}',AuthorName='{book.AuthorName}',Category='{book.Category}',UnitPrice={book.UnitPrice},PublishedAt='{book.PublishedAt}',PublisherName='{book.PublisherName}',Volume='{book.Volume}' where Id='{book.Id}' ";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            if (result > 0)
                return true;
            return false;
        }
    }
}
