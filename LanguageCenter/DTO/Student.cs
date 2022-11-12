﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenter.DTO
{
    class Student
    {
        public string Username { get; set; }
        public string Date_Birth { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Student()
        {

        }
        public Student(string username, string datebirth, string address, string name, string email, string phone, string position)
        {
            this.Username = username;
            this.Date_Birth = datebirth;
            this.Address = address;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }
    }
}
