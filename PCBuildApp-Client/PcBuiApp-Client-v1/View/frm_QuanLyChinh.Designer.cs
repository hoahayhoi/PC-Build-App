namespace PcBuiApp_Client_v1.View
{
    partial class frm_QuanLyChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyChinh));
            btn_CloseLogin = new Button();
            pictureBox1 = new PictureBox();
            roundedUserControl1 = new UserControlCustom.RoundedUserControl();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btn_QuanLyTaiKhoan = new Button();
            btn_QuanLyKho = new Button();
            btn_QuanLyLapRap = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedUserControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_CloseLogin
            // 
            btn_CloseLogin.Location = new Point(1367, 12);
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
            pictureBox1.Location = new Point(-187, -57);
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
            roundedUserControl1.Controls.Add(pictureBox2);
            roundedUserControl1.Controls.Add(label1);
            roundedUserControl1.Controls.Add(btn_QuanLyTaiKhoan);
            roundedUserControl1.Controls.Add(btn_QuanLyKho);
            roundedUserControl1.Controls.Add(btn_QuanLyLapRap);
            roundedUserControl1.Controls.Add(button3);
            roundedUserControl1.Controls.Add(button2);
            roundedUserControl1.Controls.Add(button1);
            roundedUserControl1.Controls.Add(pictureBox1);
            roundedUserControl1.CornerRadius = 50;
            roundedUserControl1.Location = new Point(12, 12);
            roundedUserControl1.Name = "roundedUserControl1";
            roundedUserControl1.Size = new Size(345, 836);
            roundedUserControl1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(115, 193);
            label1.Name = "label1";
            label1.Size = new Size(162, 17);
            label1.TabIndex = 1;
            label1.Text = "homykim@gmail.com.vn";
            // 
            // btn_QuanLyTaiKhoan
            // 
            btn_QuanLyTaiKhoan.BackColor = SystemColors.ButtonFace;
            btn_QuanLyTaiKhoan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_QuanLyTaiKhoan.Image = (Image)resources.GetObject("btn_QuanLyTaiKhoan.Image");
            btn_QuanLyTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btn_QuanLyTaiKhoan.Location = new Point(21, 668);
            btn_QuanLyTaiKhoan.Name = "btn_QuanLyTaiKhoan";
            btn_QuanLyTaiKhoan.Padding = new Padding(20, 0, 0, 0);
            btn_QuanLyTaiKhoan.Size = new Size(296, 48);
            btn_QuanLyTaiKhoan.TabIndex = 16;
            btn_QuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            btn_QuanLyTaiKhoan.UseVisualStyleBackColor = false;
            btn_QuanLyTaiKhoan.Click += btn_QuanLyTaiKhoan_Click;
            // 
            // btn_QuanLyKho
            // 
            btn_QuanLyKho.BackColor = SystemColors.ButtonFace;
            btn_QuanLyKho.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_QuanLyKho.Image = (Image)resources.GetObject("btn_QuanLyKho.Image");
            btn_QuanLyKho.ImageAlign = ContentAlignment.MiddleLeft;
            btn_QuanLyKho.Location = new Point(21, 588);
            btn_QuanLyKho.Name = "btn_QuanLyKho";
            btn_QuanLyKho.Padding = new Padding(20, 0, 0, 0);
            btn_QuanLyKho.Size = new Size(296, 48);
            btn_QuanLyKho.TabIndex = 5;
            btn_QuanLyKho.Text = "Quản Lý Kho";
            btn_QuanLyKho.UseVisualStyleBackColor = false;
            btn_QuanLyKho.Click += btn_QuanLyKho_Click;
            // 
            // btn_QuanLyLapRap
            // 
            btn_QuanLyLapRap.BackColor = SystemColors.ButtonFace;
            btn_QuanLyLapRap.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_QuanLyLapRap.Image = (Image)resources.GetObject("btn_QuanLyLapRap.Image");
            btn_QuanLyLapRap.ImageAlign = ContentAlignment.MiddleLeft;
            btn_QuanLyLapRap.Location = new Point(21, 507);
            btn_QuanLyLapRap.Name = "btn_QuanLyLapRap";
            btn_QuanLyLapRap.Padding = new Padding(20, 0, 0, 0);
            btn_QuanLyLapRap.Size = new Size(296, 48);
            btn_QuanLyLapRap.TabIndex = 4;
            btn_QuanLyLapRap.Text = "Quản Lý Lắp Ráp";
            btn_QuanLyLapRap.UseVisualStyleBackColor = false;
            btn_QuanLyLapRap.Click += btn_QuanLyLapRap_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(21, 424);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(296, 48);
            button3.TabIndex = 3;
            button3.Text = "Quản Lý Đơn Hàng";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(21, 348);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(296, 48);
            button2.TabIndex = 2;
            button2.Text = "Đề Xuất Cấu Hình";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(21, 269);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(296, 48);
            button1.TabIndex = 1;
            button1.Text = "Trang Chủ";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(383, 12);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1018, 836);
            panelMain.TabIndex = 20;
            // 
            // frm_QuanLyChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1411, 869);
            Controls.Add(roundedUserControl1);
            Controls.Add(btn_CloseLogin);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_QuanLyChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedUserControl1.ResumeLayout(false);
            roundedUserControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_CloseLogin;
        private UserControlCustom.RoundedUserControl roundedUserControl1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btn_QuanLyLapRap;
        private Button btn_QuanLyKho;
        private Button btn_QuanLyTaiKhoan;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panelMain;
    }
}