﻿using LanguageCenter.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenter.DAO
{
    class StaffDAO
    {
        public StaffDAO()
        {

        }
        public Staff getStaffByUsername(string username)
        {
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();

            command.CommandText = "select * from Staffs where Staffs.Username = @username";
            command.Parameters.Add(new SqlParameter("@username", username));

            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                if (!reader.Read())
                {
                    return null;
                }
                Staff st = new Staff();
                st.ID = Convert.ToInt32(reader["ID"]);
                st.Username = Convert.ToString(reader["Username"]);
                st.Position = Convert.ToString(reader["Position"]);
                st.Date_Birth = Convert.ToString(reader["Date_Birth"]);
                st.Address = Convert.ToString(reader["Address"]);
                st.First_Name = Convert.ToString(reader["First_Name"]);
                st.Last_Name = Convert.ToString(reader["Last_Name"]);
                st.Email = Convert.ToString(reader["Email"]);
                st.Phone = Convert.ToString(reader["Phone"]);

                return st;

            }
;
        }
    }
}
