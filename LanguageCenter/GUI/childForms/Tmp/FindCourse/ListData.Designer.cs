namespace LanguageCenter.GUI.childForms.Tmp.FindCourse
{
    partial class ListData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewFindCourses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFindCourses
            // 
            this.dataGridViewFindCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFindCourses.Location = new System.Drawing.Point(-3, 48);
            this.dataGridViewFindCourses.Name = "dataGridViewFindCourses";
            this.dataGridViewFindCourses.RowHeadersWidth = 51;
            this.dataGridViewFindCourses.RowTemplate.Height = 24;
            this.dataGridViewFindCourses.Size = new System.Drawing.Size(994, 370);
            this.dataGridViewFindCourses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "KẾT QUẢ CÁC KHÓA HỌC VỪA TÌM KIẾM";
            // 
            // ListData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFindCourses);
            this.Name = "ListData";
            this.Text = "ListData";
            this.Load += new System.EventHandler(this.ListData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFindCourses;
        private System.Windows.Forms.Label label1;
    }
}