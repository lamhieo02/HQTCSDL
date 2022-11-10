using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenter.GUI.childForms.Tmp
{
    public partial class InputID_EditCourse : Form
    {
        public InputID_EditCourse()
        {
            InitializeComponent();

        }

        private void InputID_EditCourse_Load(object sender, EventArgs e)
        {

        }
        public int Id_To_Edit { get; set; }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                Id_To_Edit = int.Parse(tbxID.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai định dạng dữ liệu! Mời nhập lại");
                return;
            }
            
            string query = "declare @check int; set @check = 0 select @check = ID from Courses where id = @id select @check";
            SqlConnection conn = DAL.DataAccess.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = Id_To_Edit;

            int a = int.Parse(cmd.ExecuteScalar().ToString());
            if (a == 0)
            {
                MessageBox.Show("Id khóa học bạn muốn sửa không có trong database");
                return;
            }
            Form childForm = new childForms.CourseInfo(Id_To_Edit);
            childForm.ShowDialog();
        }

        private void tbxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
