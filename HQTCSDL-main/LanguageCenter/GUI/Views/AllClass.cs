﻿using System;
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
    public partial class AllClass : Form
    {
        public AllClass()
        {
            InitializeComponent();
        }

        private void AllClass_Load(object sender, EventArgs e)
        {
            AllClass_Gridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllClass_Gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllClass_Gridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DisplayAllClassesList();
        }
        public void DisplayAllClassesList()
        {

            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter("getAllClasses", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            AllClass_Gridview.DataSource = dt;
        }

        private void searchCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchCbb.SelectedIndex == 0) //class name
            {
                GetClassByClasssName(txtSearch.Text);
            }
            if (searchCbb.SelectedIndex == 1) //teacher name
            {
                GetClassByTeacherName(txtSearch.Text);
            }
            if (searchCbb.SelectedIndex == 2) //course name
            {
                GetClassByCourseName(txtSearch.Text);
            }
        }
        public void GetClassByTeacherName(string name)
        {
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter("GetClassByTeacherName", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@name", SqlDbType.NVarChar, 30).Value = name;
            DataTable dt = new DataTable();
            da.Fill(dt);
            AllClass_Gridview.DataSource = dt;
        }
        public void GetClassByClasssID(int id)
        {
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter("GetClassByClassID", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable dt = new DataTable();
            da.Fill(dt);
            AllClass_Gridview.DataSource = dt;
        }
        public void GetClassByClasssName(string name)
        {
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter("GetClassByClassName", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            DataTable dt = new DataTable();
            da.Fill(dt);
            AllClass_Gridview.DataSource = dt;
        }
        public void GetClassByCourseName(string name)
        {
            var conn = DAL.DataAccess.getConnection();
            var command = conn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter("GetClassByCourseName", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            DataTable dt = new DataTable();
            da.Fill(dt);
            AllClass_Gridview.DataSource = dt;
        }
    }
}
