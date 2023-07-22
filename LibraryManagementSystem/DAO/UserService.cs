using System.Data.SqlClient;


namespace LibraryManagementSystem.DAO {
    internal class UserService : IUserDAO {
        public bool CheckUserExists(string userEmail, string password) {
          SqlConnection con=DatabaseConnectionHelper.GetConnection();
            string sql = $"select id from users where Email='{userEmail}' AND password='{password}' ";
            SqlCommand cmd=new SqlCommand(sql,con);
            var result=cmd.ExecuteScalar();
            if(result!=null) return true;
            else return false;
        }
    }
}
