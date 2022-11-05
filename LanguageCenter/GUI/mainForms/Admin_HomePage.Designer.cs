
namespace LanguageCenter.GUI
{
    partial class Admin_HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.changePwBtn = new System.Windows.Forms.Button();
            this.SalaryMnBtn = new System.Windows.Forms.Button();
            this.staffMnBtn = new System.Windows.Forms.Button();
            this.teacherMnBtn = new System.Windows.Forms.Button();
            this.studentMnBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 86);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.changePwBtn);
            this.panel2.Controls.Add(this.SalaryMnBtn);
            this.panel2.Controls.Add(this.staffMnBtn);
            this.panel2.Controls.Add(this.teacherMnBtn);
            this.panel2.Controls.Add(this.studentMnBtn);
            this.panel2.Controls.Add(this.profileBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 851);
            this.panel2.TabIndex = 2;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.button1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(273, 86);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(950, 851);
            this.panelDesktopPane.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Image = global::LanguageCenter.Properties.Resources._5514;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(950, 851);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = global::LanguageCenter.Properties.Resources.logout;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 576);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(273, 96);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "         Đăng xuất";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // changePwBtn
            // 
            this.changePwBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.changePwBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.changePwBtn.FlatAppearance.BorderSize = 0;
            this.changePwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePwBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.changePwBtn.ForeColor = System.Drawing.Color.White;
            this.changePwBtn.Image = global::LanguageCenter.Properties.Resources.settings;
            this.changePwBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePwBtn.Location = new System.Drawing.Point(0, 480);
            this.changePwBtn.Name = "changePwBtn";
            this.changePwBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.changePwBtn.Size = new System.Drawing.Size(273, 96);
            this.changePwBtn.TabIndex = 9;
            this.changePwBtn.Text = "         Đổi mật khẩu";
            this.changePwBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePwBtn.UseVisualStyleBackColor = false;
            this.changePwBtn.Click += new System.EventHandler(this.changePwBtn_Click);
            // 
            // SalaryMnBtn
            // 
            this.SalaryMnBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalaryMnBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalaryMnBtn.FlatAppearance.BorderSize = 0;
            this.SalaryMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryMnBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SalaryMnBtn.ForeColor = System.Drawing.Color.White;
            this.SalaryMnBtn.Image = global::LanguageCenter.Properties.Resources.wallet;
            this.SalaryMnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalaryMnBtn.Location = new System.Drawing.Point(0, 384);
            this.SalaryMnBtn.Name = "SalaryMnBtn";
            this.SalaryMnBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SalaryMnBtn.Size = new System.Drawing.Size(273, 96);
            this.SalaryMnBtn.TabIndex = 7;
            this.SalaryMnBtn.Text = "         Quản lí lương";
            this.SalaryMnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalaryMnBtn.UseVisualStyleBackColor = false;
            this.SalaryMnBtn.Click += new System.EventHandler(this.SalaryMnBtn_Click);
            // 
            // staffMnBtn
            // 
            this.staffMnBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.staffMnBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffMnBtn.FlatAppearance.BorderSize = 0;
            this.staffMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffMnBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.staffMnBtn.ForeColor = System.Drawing.Color.White;
            this.staffMnBtn.Image = global::LanguageCenter.Properties.Resources.representative;
            this.staffMnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffMnBtn.Location = new System.Drawing.Point(0, 288);
            this.staffMnBtn.Name = "staffMnBtn";
            this.staffMnBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.staffMnBtn.Size = new System.Drawing.Size(273, 96);
            this.staffMnBtn.TabIndex = 3;
            this.staffMnBtn.Text = "         Quản lí nhân viên";
            this.staffMnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffMnBtn.UseVisualStyleBackColor = false;
            this.staffMnBtn.Click += new System.EventHandler(this.staffMnBtn_Click);
            // 
            // teacherMnBtn
            // 
            this.teacherMnBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.teacherMnBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherMnBtn.FlatAppearance.BorderSize = 0;
            this.teacherMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherMnBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.teacherMnBtn.ForeColor = System.Drawing.Color.White;
            this.teacherMnBtn.Image = global::LanguageCenter.Properties.Resources.teacher;
            this.teacherMnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacherMnBtn.Location = new System.Drawing.Point(0, 192);
            this.teacherMnBtn.Name = "teacherMnBtn";
            this.teacherMnBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.teacherMnBtn.Size = new System.Drawing.Size(273, 96);
            this.teacherMnBtn.TabIndex = 2;
            this.teacherMnBtn.Text = "         Quản lí giảng viên";
            this.teacherMnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacherMnBtn.UseVisualStyleBackColor = false;
            this.teacherMnBtn.Click += new System.EventHandler(this.teacherMnBtn_Click);
            // 
            // studentMnBtn
            // 
            this.studentMnBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.studentMnBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentMnBtn.FlatAppearance.BorderSize = 0;
            this.studentMnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentMnBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.studentMnBtn.ForeColor = System.Drawing.Color.White;
            this.studentMnBtn.Image = global::LanguageCenter.Properties.Resources.student_admin;
            this.studentMnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentMnBtn.Location = new System.Drawing.Point(0, 96);
            this.studentMnBtn.Name = "studentMnBtn";
            this.studentMnBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.studentMnBtn.Size = new System.Drawing.Size(273, 96);
            this.studentMnBtn.TabIndex = 1;
            this.studentMnBtn.Text = "         Quản lí học viên";
            this.studentMnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentMnBtn.UseVisualStyleBackColor = false;
            this.studentMnBtn.Click += new System.EventHandler(this.studentMnBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.profileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Image = global::LanguageCenter.Properties.Resources.user;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(0, 0);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.profileBtn.Size = new System.Drawing.Size(273, 96);
            this.profileBtn.TabIndex = 0;
            this.profileBtn.Text = "         Hồ sơ";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Image = global::LanguageCenter.Properties.Resources.manager;
            this.txtName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Location = new System.Drawing.Point(981, 0);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(0, 30, 10, 25);
            this.txtName.Size = new System.Drawing.Size(242, 77);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "        Pham Quynh Huong";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::LanguageCenter.Properties.Resources.education;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 30, 0, 25);
            this.label1.Size = new System.Drawing.Size(255, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "                Language Center";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Admin_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 937);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_HomePage";
            this.Text = "Admin_HomePage";
            this.Load += new System.EventHandler(this.Admin_HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button staffMnBtn;
        private System.Windows.Forms.Button teacherMnBtn;
        private System.Windows.Forms.Button studentMnBtn;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SalaryMnBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button changePwBtn;
    }
}