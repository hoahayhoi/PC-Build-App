﻿namespace App
{
    partial class frm_Login
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
            this.loginUserControl1 = new App.LoginUserControl();
            this.SuspendLayout();
            // 
            // loginUserControl1
            // 
            this.loginUserControl1.Location = new System.Drawing.Point(53, 90);
            this.loginUserControl1.Name = "loginUserControl1";
            this.loginUserControl1.Size = new System.Drawing.Size(793, 427);
            this.loginUserControl1.TabIndex = 0;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 537);
            this.Controls.Add(this.loginUserControl1);
            this.Name = "frm_Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginUserControl loginUserControl1;
    }
}