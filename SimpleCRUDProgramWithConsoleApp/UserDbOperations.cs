using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace SimpleCRUDProgramWithConsoleApp {
    public class UserDbOperations {

        public List<UserModel> GetUsers() {
            List<UserModel> users = new List<UserModel>();
            SqlConnection con=DbConnection.GetSqlConnection();//create a sqlConnection and get connection
            string sql = "SELECT * FROM Users";//prepare the sql select command
            SqlCommand sqlCommand =new SqlCommand(sql, con);//create a sql command to get the result 
            SqlDataReader reader = sqlCommand.ExecuteReader();//reading the records with DataReader 
         
            while (reader.Read()) {
                UserModel user = new UserModel()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    UserName = reader["UserName"].ToString(),
                    Email = reader["email"].ToString(),
                    IsDelete = Convert.ToBoolean(reader["IsDelete"]),
                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                };
                users.Add(user);
            }
            return users;
        }

        public bool SaveUser(UserModel user) {
           SqlConnection sqlConnection = DbConnection.GetSqlConnection();
            string sql = $"insert into users values({user.Id},'{user.UserName}','{user.Email}','{user.Password}',0,'{DateTime.Now}')";
            SqlCommand sqlCommand=new SqlCommand(sql, sqlConnection);
            int result=sqlCommand.ExecuteNonQuery();// if record is inserted into table ,then return 1 or 2
            if (result > 0) {
                return true;
            }
            return false;
        }

        public bool DeleteByUserId(int Id) {
            SqlConnection sqlConnection=DbConnection.GetSqlConnection();
            string deleteQuery = $"delete from users where Id={Id}";
            SqlCommand sqlCommand=new SqlCommand(deleteQuery, sqlConnection);
            int result=sqlCommand.ExecuteNonQuery();
            if (result > 0) return true;
            return false;
        }

        public bool UpdateUser(UserModel user) {
            SqlConnection sqlConnection = DbConnection.GetSqlConnection();
            string sql = $"update users set username='{user.UserName}',Email='{user.Email}',password='{user.Password}',createdAt='{DateTime.Now}' where id={user.Id}";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            int result = sqlCommand.ExecuteNonQuery();// if record is inserted into table ,then return 1 or 2
            if (result > 0) {
                return true;
            }
            return false;
        }

    }
}
