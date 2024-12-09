using System.Windows.Forms;

namespace App.View.QuanLyTaiKhoan
{
    partial class DoiMatKhau
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelLeft;
        private Panel panelRight;
        private Label lblUserName;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnChangePassword;
        private Label lblCurrentPassword;
        private Label lblNewPassword;
        private Label lblConfirmPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.lblUserName);
            this.panelLeft.Controls.Add(this.lblEmail);
            this.panelLeft.Controls.Add(this.lblPhone);
            this.panelLeft.Location = new System.Drawing.Point(12, 109);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(360, 431);
            this.panelLeft.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(10, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(101, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tên đăng nhập:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email: ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(10, 100);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(88, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.lblCurrentPassword);
            this.panelRight.Controls.Add(this.lblNewPassword);
            this.panelRight.Controls.Add(this.lblConfirmPassword);
            this.panelRight.Controls.Add(this.txtCurrentPassword);
            this.panelRight.Controls.Add(this.txtNewPassword);
            this.panelRight.Controls.Add(this.txtConfirmPassword);
            this.panelRight.Controls.Add(this.btnChangePassword);
            this.panelRight.Location = new System.Drawing.Point(393, 109);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(878, 431);
            this.panelRight.TabIndex = 1;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(35, 20);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(84, 16);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "Mật Khẩu Cũ:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(35, 60);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(93, 16);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "Mật Khẩu Mới: ";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(35, 100);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(122, 16);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Nhập Lại Mật Khẩu:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(155, 20);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(200, 22);
            this.txtCurrentPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(155, 60);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(200, 22);
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(155, 100);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 22);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(155, 176);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(200, 30);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "Đổi Mật Khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 38;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(1053, 23);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(116, 34);
            this.button_Thoat.TabIndex = 39;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // DoiMatKhau
            // 
            this.ClientSize = new System.Drawing.Size(1283, 571);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Name = "DoiMatKhau";
            this.Text = "Change Password";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Button button_Thoat;
    }
}
