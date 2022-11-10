using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenter.GUI.childForms.Tmp.FindCourse
{
    public partial class ListData : Form
    {
        public DataTable dt;
        public ListData(DataTable dtTmp)
        {
            InitializeComponent();
            this.dt = dtTmp;
        }

        private void ListData_Load(object sender, EventArgs e)
        {
            dataGridViewFindCourses.DataSource = dt;
        }
    }
}
