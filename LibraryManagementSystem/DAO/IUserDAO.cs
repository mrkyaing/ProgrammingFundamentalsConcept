using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAO {
    public interface IUserDAO {
        bool CheckUserExists(string username,string password);
    }
}
