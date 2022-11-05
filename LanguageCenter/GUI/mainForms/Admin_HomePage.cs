using LanguageCenter.GUI.mainForms;
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
    public partial class Admin_HomePage : Form
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
        public Admin_HomePage()
        {
            InitializeComponent();
        }
        private void Admin_HomePage_Load(object sender, EventArgs e)
        {
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

        private void studentMnBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.StudentManage(), sender);
        }

        private void teacherMnBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.TeacherManage(), sender);
        }

        private void staffMnBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.StaffManage(), sender);
        }
        private void changePwBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.Student_ChangePw(), sender);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.ShowDialog();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.Profile(), sender);
        }
    }
}
