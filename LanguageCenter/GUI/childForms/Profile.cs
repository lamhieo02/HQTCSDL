using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenter.GUI.childForms
{
    public partial class Profile : Form
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
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            txtName.Text = Last_Name + " " + First_Name;
            txtUsername.Text = Username;
            txtPosition.Text = Position;
            txtAddress.Text = Address;
            txtDateBirth.Text = Date_Birth;
            txtEmail.Text = Email;
            txtPhone.Text = Phone;

        }
    }
}
