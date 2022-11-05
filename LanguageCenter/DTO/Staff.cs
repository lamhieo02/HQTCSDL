using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenter.DTO
{
    class Staff
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public string Date_Birth { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Staff()
        {

        }
        public Staff(int id, string username,string position, string address, string datebirth, string firstname, string lastname, string email, string phone)
        {
            ID = id;
            Username = username;
            Position = position;
            Address = address;
            Date_Birth = datebirth;
            First_Name = firstname;
            Last_Name = lastname;
            Email = email;
            Phone = phone;
        }
    }
}
