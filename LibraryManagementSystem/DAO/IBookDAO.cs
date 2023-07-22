using LibraryManagementSystem.Models;
using System.Collections.Generic;

namespace LibraryManagementSystem.DAO {
    public interface IBookDAO {
        bool Create(BookModel book);
        List<BookModel> GetAll();
        bool Delete(string Id);
        bool Update(BookModel book);
    }
}
