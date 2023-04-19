using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SchoolStudent
{
    public class Dboperation 
    {
        public static List<UserModle> GetAllUser()
        {
            List<UserModle> Student = new List<UserModle>();
            SqlConnection sqlConnection = DatabaseConnection.GetSqlConnection();
            string query = "select * from Student";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader Reads = sqlCommand.ExecuteReader();
           
                while (Reads.Read())
                {
                UserModle users = new UserModle()
                {
                    id = Convert.ToInt32(Reads["id"]),
                    name = Reads["Name"].ToString(),
                    phone = Reads["phone"].ToString(),
                    Email = Reads["Email"].ToString(),
                    Adress = Reads["Adress"].ToString()  
                   
                    };
                    Student.Add(users);
                }
            return Student;
        }
        public bool SaveUser(UserModle user)
        {
            List<UserModle> Students= new List<UserModle>();
            SqlConnection sqlConnection = DatabaseConnection.GetSqlConnection();
            string query = $"insert into Student values({user.id},'{user.name}','{user.phone}','{user.Email}','{user.Adress}')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            var result = sqlCommand.ExecuteNonQuery();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteUser(int Id)
        {
            List<UserModle> students = new List<UserModle>();
            SqlConnection sqlConnection = DatabaseConnection.GetSqlConnection();
            string query = $"delete from student where id = {Id}";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            int result = sqlCommand.ExecuteNonQuery();
            if(result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
