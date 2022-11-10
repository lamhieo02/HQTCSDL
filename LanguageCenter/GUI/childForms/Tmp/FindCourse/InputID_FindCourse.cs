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

namespace LanguageCenter.GUI.childForms.Tmp
{
    public partial class InputID_FindCourse : Form
    {
        public InputID_FindCourse()
        {
            InitializeComponent();
        }
        public int Id_LanguageToFindCourse;
        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                Id_LanguageToFindCourse = int.Parse(tbxID_Language.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai định dạng dữ liệu! Mời nhập lại");
                return;
            }

            string query = "declare @check int; set @check = 0 select @check = ID from Languages where id = @id select @check";
            SqlConnection conn = DAL.DataAccess.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = Id_LanguageToFindCourse;

            //cmd.Cancel();
            int a = int.Parse(cmd.ExecuteScalar().ToString());
            if (a == 0)
            {
                MessageBox.Show("Id Language bạn muốn tìm không có trong database");
                return;
            }

            conn = DAL.DataAccess.getConnection();
            cmd = new SqlCommand("TIMKIEM_KHOAHOC_LanguageID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_nn ", Id_LanguageToFindCourse);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            Form listData = new childForms.Tmp.FindCourse.ListData(dt);
            listData.ShowDialog();
            //dataGridView2.DataSource = dt;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputID_FindCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
