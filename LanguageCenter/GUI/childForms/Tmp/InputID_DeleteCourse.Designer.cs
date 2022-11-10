namespace LanguageCenter.GUI.childForms.Tmp
{
    partial class InputID_DeleteCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIdDelete = new System.Windows.Forms.TextBox();
            this.btnContinueDelete = new System.Windows.Forms.Button();
            this.btnExitDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập ID khóa học muốn xóa:";
            // 
            // tbxIdDelete
            // 
            this.tbxIdDelete.Location = new System.Drawing.Point(196, 21);
            this.tbxIdDelete.Name = "tbxIdDelete";
            this.tbxIdDelete.Size = new System.Drawing.Size(100, 22);
            this.tbxIdDelete.TabIndex = 1;
            // 
            // btnContinueDelete
            // 
            this.btnContinueDelete.Location = new System.Drawing.Point(118, 61);
            this.btnContinueDelete.Name = "btnContinueDelete";
            this.btnContinueDelete.Size = new System.Drawing.Size(83, 27);
            this.btnContinueDelete.TabIndex = 2;
            this.btnContinueDelete.Text = "Xác nhận";
            this.btnContinueDelete.UseVisualStyleBackColor = true;
            this.btnContinueDelete.Click += new System.EventHandler(this.btnContinueDelete_Click);
            // 
            // btnExitDelete
            // 
            this.btnExitDelete.Location = new System.Drawing.Point(221, 61);
            this.btnExitDelete.Name = "btnExitDelete";
            this.btnExitDelete.Size = new System.Drawing.Size(75, 27);
            this.btnExitDelete.TabIndex = 3;
            this.btnExitDelete.Text = "Hủy";
            this.btnExitDelete.UseVisualStyleBackColor = true;
            this.btnExitDelete.Click += new System.EventHandler(this.btnExitDelete_Click);
            // 
            // InputID_DeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 115);
            this.Controls.Add(this.btnExitDelete);
            this.Controls.Add(this.btnContinueDelete);
            this.Controls.Add(this.tbxIdDelete);
            this.Controls.Add(this.label1);
            this.Name = "InputID_DeleteCourse";
            this.Text = "InputID_DeleteCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIdDelete;
        private System.Windows.Forms.Button btnContinueDelete;
        private System.Windows.Forms.Button btnExitDelete;
    }
}