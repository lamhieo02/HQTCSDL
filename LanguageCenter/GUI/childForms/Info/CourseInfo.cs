using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenter.GUI.childForms
{
    public partial class CourseInfo : Form
    {
        public CourseInfo()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int lesson;
            string description = tbxDescr.Text.ToString();
            string term = tbxTerm.Text.ToString();
            int languageId;
            int levelId;
            int categoryId;
            if (description == "" || term == "" )
            {
                MessageBox.Show("Phải điền đầy đủ thông tin");
                return;
            }

            try
            {
                lesson = int.Parse(tbxLesson.Text.ToString());
                languageId = int.Parse(tbxLanguageID.Text.ToString());
                levelId = int.Parse(tbxLevelID.Text.ToString());
                categoryId = int.Parse(tbxCategoryID.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu");
                return;
            }

            // Add Course to Database
            string query = "insert into Courses values (@lesson, @desc, @term, @languageId, @levelId, @categoryId)";
            SqlConnection conn = DAL.DataAccess.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);


            cmd.Parameters.Add("@lesson", SqlDbType.Int);
            cmd.Parameters.Add("@desc", SqlDbType.NVarChar);
            cmd.Parameters.Add("@term", SqlDbType.NVarChar);
            cmd.Parameters.Add("@languageId", SqlDbType.Int);
            cmd.Parameters.Add("@levelId", SqlDbType.Int);
            cmd.Parameters.Add("@categoryId", SqlDbType.Int);


            cmd.Parameters["@lesson"].Value = lesson;
            cmd.Parameters["@desc"].Value = description;
            cmd.Parameters["@term"].Value = term;
            cmd.Parameters["@languageId"].Value = languageId;
            cmd.Parameters["@levelId"].Value = levelId;
            cmd.Parameters["@categoryId"].Value = categoryId;

            cmd.ExecuteReader();

            MessageBox.Show("Đã thêm course thành công");
            conn.Close();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
