using LanguageCenter.GUI.childForms.Tmp;
using System;
using System.Collections;
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
        public int Id_To_Edit = 0;
        public CourseInfo(int _Id_To_Edit)
        {
            this.Id_To_Edit = _Id_To_Edit;
            InitializeComponent();
        }
        public CourseInfo()
        {
            InitializeComponent();
        }


        public void AddParameter(SqlCommand cmd, int lesson, string description, string term, int languageId, int levelId, int categoryId)
        {
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

            bool checkIsActive = false;
            if (Application.OpenForms.OfType<Tmp.InputID_EditCourse>().Any())
                //MessageBox.Show("Form is opened");
                checkIsActive = true;

            SqlConnection conn = DAL.DataAccess.getConnection();

            if (checkIsActive)
            {
                // Edit Course to Database
                string query = "update Courses Set Lessons = @lesson, Description = @desc, Term = @term, Language_ID =  @languageId, Level_ID = @levelId, Category_ID = @categoryId where ID = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = Id_To_Edit;

                AddParameter(cmd, lesson, description, term, languageId, levelId, categoryId);
                cmd.ExecuteReader();

                MessageBox.Show("Đã sửa thông tin của khóa học thành công");
            }
            else
            {
                // Add Course to Database
                string query = "insert into Courses values (@lesson, @desc, @term, @languageId, @levelId, @categoryId)";

                SqlCommand cmd = new SqlCommand(query, conn);


                AddParameter(cmd, lesson, description, term, languageId, levelId, categoryId);

                cmd.ExecuteReader();

                MessageBox.Show("Đã thêm course thành công");

            }
            conn.Close();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
