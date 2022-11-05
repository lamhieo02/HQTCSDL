using LanguageCenter.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenter.DAO
{
    class TeacherDAO
    {
        public TeacherDAO()
        {

        }
        public Teacher getTeacherByUsername(string username)
        {
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();

            command.CommandText = "select * from Teachers where Teachers.Username = @username";
            command.Parameters.Add(new SqlParameter("@username", username));

            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                if (!reader.Read())
                {
                    return null;
                }
                Teacher teacher = new Teacher();
                teacher.ID = Convert.ToInt32(reader["ID"]);
                teacher.Username = Convert.ToString(reader["Username"]);
                teacher.Date_Birth = Convert.ToString(reader["Date_Birth"]);
                teacher.Address = Convert.ToString(reader["Address"]);
                teacher.First_Name = Convert.ToString(reader["First_Name"]);
                teacher.Last_Name = Convert.ToString(reader["Last_Name"]);
                teacher.Email = Convert.ToString(reader["Email"]);
                teacher.Phone = Convert.ToString(reader["Phone"]);

                return teacher;

            }
;
        }
    }
}
