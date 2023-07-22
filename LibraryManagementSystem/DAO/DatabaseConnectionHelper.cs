using System;
using System.Data.SqlClient;

namespace LibraryManagementSystem.DAO {
    public class DatabaseConnectionHelper {

        public static SqlConnection GetConnection() {
            string connectionString = @"server=DESKTOP-SLJ8JS6\MSSQLSERVER2019;initial catalog=lms;user id=sa;password=sasa";
            try {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return sqlConnection;
            }catch (Exception ex) {
                throw new Exception("error occur when connect to databae ");
            }
        }

    }
}
