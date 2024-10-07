namespace PcBuiApp_Client_v1.View
{
    partial class frm_QuanLyNhanVien
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
            btn_CloseLogin = new Button();
            pictureBox1 = new PictureBox();
            roundedUserControl1 = new UserControlCustom.RoundedUserControl();
            roundedUserControl2 = new UserControlCustom.RoundedUserControl();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedUserControl1.SuspendLayout();
            roundedUserControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            btn_CloseLogin.Click += btn_CloseLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.maxresdefault;
            pictureBox1.Location = new Point(-196, -36);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(736, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // roundedUserControl1
            // 
            roundedUserControl1.BackColor = Color.White;
            roundedUserControl1.Controls.Add(roundedUserControl2);
            roundedUserControl1.Controls.Add(pictureBox1);
            roundedUserControl1.CornerRadius = 50;
            roundedUserControl1.Location = new Point(12, 12);
            roundedUserControl1.Name = "roundedUserControl1";
            roundedUserControl1.Size = new Size(345, 836);
            roundedUserControl1.TabIndex = 15;
            // 
            // roundedUserControl2
            // 
            roundedUserControl2.Controls.Add(pictureBox2);
            roundedUserControl2.Controls.Add(label1);
            roundedUserControl2.CornerRadius = 20;
            roundedUserControl2.Location = new Point(18, 216);
            roundedUserControl2.Name = "roundedUserControl2";
            roundedUserControl2.Size = new Size(302, 63);
            roundedUserControl2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1000_F_272554194_9bJhYSJkUcLbTjXfDlDANV2RyQYGO06N;
            pictureBox2.Location = new Point(13, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 20);
            label1.Name = "label1";
            label1.Size = new Size(198, 19);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Tài Khoản Nhân Viên";
            // 
            // frm_QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            roundedUserControl2.ResumeLayout(false);
            roundedUserControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_CloseLogin;
        private UserControlCustom.RoundedUserControl roundedUserControl1;
        private UserControlCustom.RoundedUserControl roundedUserControl2;
        private PictureBox pictureBox2;
        private Label label1;
    }
}