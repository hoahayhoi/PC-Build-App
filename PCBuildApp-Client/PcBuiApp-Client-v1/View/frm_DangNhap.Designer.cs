namespace PcBuiApp_Client_v1.View
{
    partial class frm_DangNhap
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
            textBox_UserName = new TextBox();
            textBox_Password = new TextBox();
            btn_Login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_CloseLogin = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            checkBox_ForgotPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_UserName
            // 
            textBox_UserName.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_UserName.Location = new Point(675, 222);
            textBox_UserName.Margin = new Padding(4, 3, 4, 3);
            textBox_UserName.Name = "textBox_UserName";
            textBox_UserName.Size = new Size(395, 27);
            textBox_UserName.TabIndex = 4;
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Password.Location = new Point(675, 347);
            textBox_Password.Margin = new Padding(4, 3, 4, 3);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(395, 27);
            textBox_Password.TabIndex = 6;
            textBox_Password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.OrangeRed;
            btn_Login.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(786, 484);
            btn_Login.Margin = new Padding(4, 3, 4, 3);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(210, 72);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "Đăng Nhập";
            btn_Login.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(658, 182);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 8;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(658, 301);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 9;
            label2.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(764, 106);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 10;
            // 
            // btn_CloseLogin
            // 
            btn_CloseLogin.Location = new Point(1139, 14);
            btn_CloseLogin.Margin = new Padding(4, 3, 4, 3);
            btn_CloseLogin.Name = "btn_CloseLogin";
            btn_CloseLogin.Size = new Size(34, 27);
            btn_CloseLogin.TabIndex = 12;
            btn_CloseLogin.Text = "X";
            btn_CloseLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.InactiveCaption;
            pictureBox4.Location = new Point(662, 327);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(424, 69);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.InactiveCaption;
            pictureBox3.Location = new Point(662, 208);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(424, 69);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.maxresdefault;
            pictureBox1.Location = new Point(-86, -245);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(693, 1139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox_ForgotPassword
            // 
            checkBox_ForgotPassword.AutoSize = true;
            checkBox_ForgotPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_ForgotPassword.Location = new Point(662, 421);
            checkBox_ForgotPassword.Margin = new Padding(4, 3, 4, 3);
            checkBox_ForgotPassword.Name = "checkBox_ForgotPassword";
            checkBox_ForgotPassword.Size = new Size(129, 24);
            checkBox_ForgotPassword.TabIndex = 13;
            checkBox_ForgotPassword.Text = "Nhớ Mật Khẩu";
            checkBox_ForgotPassword.UseVisualStyleBackColor = true;
            // 
            // frm_DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1148, 668);
            Controls.Add(checkBox_ForgotPassword);
            Controls.Add(btn_CloseLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Login);
            Controls.Add(textBox_Password);
            Controls.Add(pictureBox4);
            Controls.Add(textBox_UserName);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CloseLogin;
        private System.Windows.Forms.CheckBox checkBox_ForgotPassword;
    }
}