using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SchoolStudent
{
    public class DatabaseConnection
    {
        public static SqlConnection GetSqlConnection() 
        {
            SqlConnection connection = null;
            string ConnectionString = "Server=Localhost;Initial Catalog =MyDb;User Id=sa;Password = kst11";
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
