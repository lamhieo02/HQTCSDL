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
    public partial class InputID_DeleteCourse : Form
    {
        public InputID_DeleteCourse()
        {
            InitializeComponent();
        }
        public int Id_To_Delete { get; set; }
        private void btnContinueDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Id_To_Delete = int.Parse(tbxIdDelete.Text.ToString());
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
            cmd.Parameters["@id"].Value = Id_To_Delete;

            //cmd.Cancel();
            int a = int.Parse(cmd.ExecuteScalar().ToString());
            if (a == 0)
            {
                MessageBox.Show("Id khóa học bạn muốn xóa không có trong database");
                return;
            }
            try
            {
                string queryToDelete = String.Format("delete from Courses where ID = {0}", Id_To_Delete);
                cmd = new SqlCommand(queryToDelete, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Đã xóa khóa học thành công");
            }
            catch
            {
                MessageBox.Show("Khóa học bạn muốn xóa không thể xóa! For dev: <Vì nó là Foreign key của các Object khác :)) >"); // Vì nó là Foreign key của các Object khác
            }
            
        }

        private void btnExitDelete_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
