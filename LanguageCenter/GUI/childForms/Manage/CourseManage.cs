using LanguageCenter.GUI.childForms;
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
    public partial class CourseManage : Form
    {

        public CourseManage()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //public class InfoCourse
        //{
        //    public InfoCourse()
        //    {
        //    }

        //    public int ID { get; set; }
        //    public String Lessons { get; set; }
        //    public String Description { get; set; }
        //    public String Term { get; set; }
        //    public String LanguageName { get; set; }
        //    public String LevelName { get; set; }
        //    public String CategoryName { get; set; }

        //    public InfoCourse(int iD, string lessons, string description, string term, string languageName, string levelName, string categoryName)
        //    {
        //        ID = iD;
        //        Lessons = lessons;
        //        Description = description;
        //        Term = term;
        //        LanguageName = languageName;
        //        LevelName = levelName;
        //        CategoryName = categoryName;
        //    }
        //}
        SqlConnection conn = DAL.DataAccess.getConnection();
        private void btnListCourse_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Courses", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            dataGridView2.DataSource = dt;
            //MessageBox.Show("HIHI");
            conn.Close();

            conn.Open();
            List<String> listLanguageName = new List<String>();
            List<String> listLevelName = new List<String>();
            List<String> listCategoryName = new List<String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j ++)
                {
                    if (j == 4) // Solve to change LanguageID -> LanguageName
                    {

                        cmd = new SqlCommand("select L.Name from Languages L inner join Courses C on L.ID = C.Language_ID where C.ID = @id", conn);
                        cmd.Parameters.Add("@id", SqlDbType.Int);
                        cmd.Parameters["@id"].Value = dt.Rows[i][0];
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            String languageName = reader.GetString(0);
                            listLanguageName.Add(languageName);
                        }
                       
                        reader.Close();
                    }
                    if (j == 5) // Solve to change LevelID -> listLevelName
                    {
                        cmd = new SqlCommand("select L.Name from Levels L inner join Courses C on L.ID = C.Level_ID where C.ID = @id", conn);
                        cmd.Parameters.Add("@id", SqlDbType.Int);
                        cmd.Parameters["@id"].Value = dt.Rows[i][0];
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            String LevelName = reader.GetString(0);
                            listLevelName.Add(LevelName);
                        }

                        reader.Close();

                    }
                    if (j == 6) // Solve to change CategoryID -> listCategoryName
                    {
                        cmd = new SqlCommand("select L.Name from Categories L inner join Courses C on L.ID = C.Category_ID where C.ID = @id", conn);
                        cmd.Parameters.Add("@id", SqlDbType.Int);
                        cmd.Parameters["@id"].Value = dt.Rows[i][0];
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            String CategoryName = reader.GetString(0);
                            listCategoryName.Add(CategoryName);
                        }

                        reader.Close();
                    }
                }
            }
            dt.Columns.Remove("Language_ID");
            dt.Columns.Remove("Level_ID");
            dt.Columns.Remove("Category_ID");

            dt.Columns.Add("LanguageName", typeof(String));
            dt.Columns.Add("LevelName", typeof(String));
            dt.Columns.Add("CategoryName", typeof(String));
            for (int i =0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["LanguageName"] = listLanguageName[i];
                dt.Rows[i]["LevelName"] = listLevelName[i];
                dt.Rows[i]["CategoryName"] = listCategoryName[i];
            }

            dataGridView2.DataSource = dt;
            //conn.Close(); -> giữ conn luôn open để chức năng này có thể cập nhật được real-time khi ta cập nhật dữ liệu trong cơ sở dữ liệu
        }
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            Form childForm = new childForms.CourseInfo();
            childForm.ShowDialog();
            //this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            Form childForm = new childForms.Tmp.InputID_EditCourses();
            childForm.ShowDialog();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            Form childForm = new childForms.Tmp.InputID_DeleteCourse();
            childForm.ShowDialog();
        }

        private void btnFindCourse_Click(object sender, EventArgs e)
        {
            Form childForm = new childForms.Tmp.InputID_FindCourse();
            childForm.ShowDialog();

            
        }
    }
}
