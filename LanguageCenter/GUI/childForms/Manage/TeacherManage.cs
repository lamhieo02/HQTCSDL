using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenter.GUI.childForms
{
    public partial class TeacherManage : Form
    {
        public TeacherManage()
        {
            InitializeComponent();
        }

        private void ClassManage_Load(object sender, EventArgs e)
        {
            teacherGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            teacherGridview.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
