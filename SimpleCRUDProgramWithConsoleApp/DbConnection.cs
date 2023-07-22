using System.Data.SqlClient;

namespace SimpleCRUDProgramWithConsoleApp {
    public class DbConnection {
        
        public static SqlConnection GetSqlConnection() {
           string connectionString = @"server=localhost;Initial Catalog=SimpleDB;User Id=sa;Password=sasa;";
            try {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return sqlConnection;
            }catch (SqlException sqlex) {
                throw sqlex;
            }
    }

    }
} 

