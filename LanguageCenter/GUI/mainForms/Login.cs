using LanguageCenter.DAO;
using LanguageCenter.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenter.GUI.mainForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void XuLiLogin()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            //xu li login
            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            AccountDAO accountDAO = new AccountDAO();
            Account account = accountDAO.getAccountByUsername(username);
            string account_pw = account.Password;
            string account_username = account.Username;
            if (password != account_pw || username != account_username)
            {
                MessageBox.Show("nhập sai thông tin!");
            }
            else
            {
                int role = accountDAO.getRoleByUserName(username);
                // LoginStudent();
                if (role == 1)
                {
                    LoginAdmin();
                }
                if (role == 2)
                {
                    LoginStaff();
                }
                if (role == 3)
                {
                    LoginStudent();
                }
                if (role == 4)
                {
                    LoginTeacher();
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            XuLiLogin();
        }
        public void LoginAdmin()
        {
            string username = txtUsername.Text;
            //lay thong tin user
            StaffDAO staff_dao = new StaffDAO();
            Staff staff = staff_dao.getStaffByUsername(username);
            Admin_HomePage staffForm = new Admin_HomePage();
            staffForm.ID = staff.ID;
            staffForm.Username = staff.Username;
            staffForm.Address = staff.Address;
            staffForm.Date_Birth = staff.Date_Birth;
            staffForm.First_Name = staff.First_Name;
            staffForm.Last_Name = staff.Last_Name;
            staffForm.Email = staff.Email;
            staffForm.Phone = staff.Phone;

            this.Hide();
            staffForm.ShowDialog();
        }
        public void LoginStaff()
        {
            string username = txtUsername.Text;
            //lay thong tin user
            StaffDAO staff_dao = new StaffDAO();
            Staff staff = staff_dao.getStaffByUsername(username);
            Staff_HomePage staffForm = new Staff_HomePage();
            staffForm.ID = staff.ID;
            staffForm.Username = staff.Username;
            staffForm.Address = staff.Address;
            staffForm.Date_Birth = staff.Date_Birth;
            staffForm.First_Name = staff.First_Name;
            staffForm.Last_Name = staff.Last_Name;
            staffForm.Email = staff.Email;
            staffForm.Phone = staff.Phone;

            this.Hide();
            staffForm.ShowDialog();
        }
        public void LoginStudent()
        {
            string username = txtUsername.Text;
            //lay thong tin user
            StudentDAO student_dao = new StudentDAO();
            Student student = student_dao.getStudentByUsername(username);
            Student_HomePage studentForm = new Student_HomePage();
            studentForm.ID = student.ID;
            studentForm.Username = student.Username;
            studentForm.Address = student.Address;
            studentForm.Date_Birth = student.Date_Birth;
            studentForm.First_Name = student.First_Name;
            studentForm.Last_Name = student.Last_Name;
            studentForm.Email = student.Email;
            studentForm.Phone = student.Phone;

            this.Hide();
            studentForm.ShowDialog();   
        }
        public void LoginTeacher()
        {
            string username = txtUsername.Text;
            //lay thong tin user
            TeacherDAO teacher_dao = new TeacherDAO();
            Teacher teacher = teacher_dao.getTeacherByUsername(username);
            Teacher_HomePage teacherForm = new Teacher_HomePage();
            teacherForm.ID = teacher.ID;
            teacherForm.Username = teacher.Username;
            teacherForm.Address = teacher.Address;
            teacherForm.Date_Birth = teacher.Date_Birth;
            teacherForm.First_Name = teacher.First_Name;
            teacherForm.Last_Name = teacher.Last_Name;
            teacherForm.Email = teacher.Email;
            teacherForm.Phone = teacher.Phone;

            this.Hide();
            teacherForm.ShowDialog();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                XuLiLogin();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /*int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            FormBorderStyle = FormBorderStyle.Sizable;
            TopMost = false;
            WindowState = FormWindowState.Normal;*/
        }
    }
}
