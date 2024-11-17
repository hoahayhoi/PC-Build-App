// frm_EditUser.Designer.cs
namespace PcBuiApp_Client_v1.View
{
    partial class frm_EditUser
    {
        private System.ComponentModel.IContainer components = null;

        // Các control trên form
        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblName;
        private TextBox txtName;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btn_Save;
        private Button btn_Cancel;
        private TextBox txtAddress;
        private Label lblAddress;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btn_Save = new Button();
            btn_Cancel = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(62, 44);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(88, 15);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Tên đăng nhập:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(182, 41);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(273, 23);
            txtUserName.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(62, 164);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(182, 161);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(273, 23);
            txtAddress.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(62, 84);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 81);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(62, 124);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(79, 15);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(182, 121);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(273, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(469, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Họ và Tên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(589, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 23);
            txtName.TabIndex = 7;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(469, 84);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(43, 15);
            lblRole.TabIndex = 8;
            lblRole.Text = "Vai trò:";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "SalesStaff", "Technician", "User" });
            cmbRole.Location = new Point(589, 81);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(273, 23);
            cmbRole.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(469, 124);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(589, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(273, 23);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(332, 205);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(123, 30);
            btn_Save.TabIndex = 12;
            btn_Save.Text = "Lưu";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(491, 205);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(123, 30);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "Hủy";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 65);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(444, 25);
            label1.TabIndex = 14;
            label1.Text = "Quản Lý Người Dùng \\ Chỉnh Sửa Người Dùng";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(btn_Cancel);
            panel2.Controls.Add(lblAddress);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(btn_Save);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(lblPhoneNumber);
            panel2.Controls.Add(cmbRole);
            panel2.Controls.Add(txtPhoneNumber);
            panel2.Controls.Add(lblRole);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(txtName);
            panel2.Location = new Point(32, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 310);
            panel2.TabIndex = 15;
            // 
            // frm_EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 423);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_EditUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chỉnh Sửa Người Dùng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}
