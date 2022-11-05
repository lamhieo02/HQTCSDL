﻿using LanguageCenter.GUI.mainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenter.GUI
{
    public partial class Teacher_HomePage : Form
    {
        private Form activeForm;
        public int ID { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Date_Birth { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Teacher_HomePage()
        {
            InitializeComponent();
        }
        private void Teacher_HomePage_Load(object sender, EventArgs e)
        {
            txtName.Text = "          " + Last_Name + " " + First_Name;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            FormBorderStyle = FormBorderStyle.Sizable;
            TopMost = false;
            WindowState = FormWindowState.Normal;
        }
        private void OpenChildForm(Form childForm, object btnSender) {
            {
                if(activeForm != null)
                {
                    activeForm.Close();
                }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktopPane.Controls.Add(childForm);
                this.panelDesktopPane.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

            } 
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            var profile = new childForms.Teacher_Profile();
            profile.ID = ID;
            profile.Username = Username;
            profile.Address = Address;
            profile.Date_Birth = Date_Birth;
            profile.First_Name = First_Name;
            profile.Last_Name = Last_Name;
            profile.Email = Email;
            profile.Phone = Phone;
            OpenChildForm(profile, sender);
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.Student_Schedule(), sender);
        }

        private void scoreBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.Student_Score(), sender);
        }

        private void changePwBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var changePw = new ChangePassword();
            changePw.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.ShowDialog();
        }
    }
}
