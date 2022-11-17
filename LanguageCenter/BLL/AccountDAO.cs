using LanguageCenter.BLL;
using LanguageCenter.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenter.BLL 
{
    class AccountDAO
    {
        public AccountDAO()
        {
        }
        public Account getAccountByUsername(string username)
        {
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();

            command.CommandText = "select * from Accounts where Accounts.Username = @username";
            command.Parameters.Add(new SqlParameter("@username", username));

            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                if (!reader.Read())
                {
                    return null;
                }
                Account account = new Account();
                account.Username = Convert.ToString(reader["Username"]);
                account.Password = Convert.ToString(reader["Password"]);
                account.RoleID = Convert.ToInt32(reader["RoleID"]);

                return account;
            }
;
        }

        public int getRoleByUserName(string username)
        {
            int role;
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();

            command.CommandText = "select Accounts.RoleID from Accounts where Accounts.Username = @username";
            command.Parameters.Add(new SqlParameter("@username", username));

            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                if (!reader.Read())
                {
                    return -1;
                }
                role = Convert.ToInt32(reader["RoleID"]);
                return role;
            }
        }

        public void changePassword(string username, string password )
        {
     
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();

            command.CommandText = "update Accounts set Accounts.Password = @password where Accounts.Username = @username";
            command.Parameters.Add(new SqlParameter("@username", username));
            command.Parameters.Add(new SqlParameter("@password", password));

            SqlDataReader reader = command.ExecuteReader();
           
        }
    }
}
