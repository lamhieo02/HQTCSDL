﻿using LanguageCenter.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenter.DAO
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
                account.ID = Convert.ToInt32(reader["ID"]);
                account.Username = Convert.ToString(reader["Username"]);
                account.Password = Convert.ToString(reader["Password"]);
                account.roleID = Convert.ToInt32(reader["RoleID"]);

                return account;
            }
;
        }

        public int getRoleByUserName(string username)
        {
            int role;
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();

            command.CommandText = "select Accounts.roleID from Accounts where Accounts.Username = @username";
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
    }
}
