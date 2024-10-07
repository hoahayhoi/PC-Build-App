
namespace PcBuiApp_Client_v1.UserControl
{
    partial class Navbar_Left
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            btn_CloseLogin = new Button();
            pictureBox1 = new PictureBox();
            roundedUserControl1 = new UserControl.RoundedUserControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedUserControl1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CloseLogin
            // 
            btn_CloseLogin.Location = new Point(1337, 12);
            btn_CloseLogin.Margin = new Padding(4, 3, 4, 3);
            btn_CloseLogin.Name = "btn_CloseLogin";
            btn_CloseLogin.Size = new Size(34, 27);
            btn_CloseLogin.TabIndex = 12;
            btn_CloseLogin.Text = "X";
            btn_CloseLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.maxresdefault;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // roundedUserControl1
            // 
            roundedUserControl1.BackColor = Color.White;
            roundedUserControl1.Controls.Add(pictureBox1);
            roundedUserControl1.CornerRadius = 50;
            roundedUserControl1.Location = new Point(12, 12);
            roundedUserControl1.Name = "roundedUserControl1";
            roundedUserControl1.Size = new Size(345, 836);
            roundedUserControl1.TabIndex = 15;
            // 
            // frm_QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1384, 869);
            Controls.Add(roundedUserControl1);
            Controls.Add(btn_CloseLogin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_QuanLyNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedUserControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_CloseLogin;
        private UserControl.RoundedUserControl roundedUserControl1;
    }
}
