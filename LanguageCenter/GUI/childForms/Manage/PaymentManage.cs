﻿using System;
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
    public partial class PaymentManage : Form
    {
        public PaymentManage()
        {
            InitializeComponent();
        }

        private void ClassManage_Load(object sender, EventArgs e)
        {
            paymentGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            paymentGridview.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
