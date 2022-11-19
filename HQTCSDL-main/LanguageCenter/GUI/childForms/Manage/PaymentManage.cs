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
    public partial class PaymentManage : Form
    {
        public PaymentManage()
        {
            InitializeComponent();
        }


        private void DisplayPaymentsList()
        {
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter("getPayments", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            paymentGridview.DataSource = dt;

            int col = paymentGridview.Columns.Count;
            paymentGridview.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (int i = 0; i < col; i++)
            {
                paymentGridview.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void ClassManage_Load(object sender, EventArgs e)
        {
            paymentGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           // paymentGridview.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DisplayPaymentsList();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string date = txtDate.Text;
            int amount = Convert.ToInt32(txtAmount.Text);
            int method = Convert.ToInt32(methodCbb.SelectedIndex)+1;
            int status = Convert.ToInt32(statusCbb.SelectedIndex);

            try
            {
                InsertPayment(date, amount, method, status, username);
            }
            catch(Exception e1)
            {
                MessageBox.Show("Thêm không thành công! Vui lòng kiểm tra lại dữ liệu Thêm! ", "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                MessageBox.Show(e1.ToString());
            }
        }
        public void InsertPayment(string payment_date, int amount, int method_id,int status,string username)
        {
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter("InsertPayment", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@payment_date", SqlDbType.Date).Value = payment_date;
            da.SelectCommand.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            da.SelectCommand.Parameters.Add("@method_id", SqlDbType.Int).Value = method_id;
            da.SelectCommand.Parameters.Add("@status", SqlDbType.Int).Value = status;
            da.SelectCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            DataTable dt = new DataTable();
            da.Fill(dt);
            paymentGridview.DataSource = dt;

            DisplayPaymentsList();
            MessageBox.Show("Thêm thành công!","Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            /*
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter("InsertPayment", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@payment_date", SqlDbType.Date).Value = payment_date;
            da.SelectCommand.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            da.SelectCommand.Parameters.Add("@method_id", SqlDbType.Int).Value = method_id;
            da.SelectCommand.Parameters.Add("@status", SqlDbType.Int).Value = status;
            da.SelectCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            DataTable dt = new DataTable();
            da.Fill(dt);
            paymentGridview.DataSource = dt;

            DisplayPaymentsList();
            MessageBox.Show("Thêm thành công!", "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);*/
        }

        private void paymentGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.paymentGridview.Rows[e.RowIndex];
                txtUsername.Text = row.Cells[0].Value.ToString();
                txtDate.Text = row.Cells[4].Value.ToString();
                txtAmount.Text = row.Cells[5].Value.ToString();
                methodCbb.Text = row.Cells[6].Value.ToString();
                int status;
                string statusStr = row.Cells[4].Value.ToString();
                if (statusStr == "Đã thanh toán") status = 1;
                else status = 0;
                statusCbb.Text = Convert.ToString(status);
            }
        }
    }
}
