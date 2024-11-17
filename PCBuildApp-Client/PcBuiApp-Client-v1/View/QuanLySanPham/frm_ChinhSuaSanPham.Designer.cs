namespace PcBuiApp_Client_v1.View.QuanLySanPham
{
    partial class frm_ChinhSuaSanPham
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtEmail = new TextBox();
            btn_Cancel = new Button();
            lblUserName = new Label();
            btn_Save = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            lblPhoneNumber = new Label();
            cmbRole = new ComboBox();
            txtPhoneNumber = new TextBox();
            lblRole = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 65);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(412, 25);
            label1.TabIndex = 14;
            label1.Text = "Quản Lý Sản Phẩm \\ Chỉnh Sửa Sản Phẩm";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(btn_Cancel);
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
            panel2.Controls.Add(lblAddress);
            panel2.Controls.Add(txtAddress);
            panel2.Location = new Point(32, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 310);
            panel2.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 81);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 23);
            txtEmail.TabIndex = 3;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(491, 205);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(123, 30);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "Hủy";
            btn_Cancel.UseVisualStyleBackColor = true;
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
            // btn_Save
            // 
            btn_Save.Location = new Point(332, 205);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(123, 30);
            btn_Save.TabIndex = 12;
            btn_Save.Text = "Lưu";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(182, 41);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(273, 23);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(589, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(273, 23);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
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
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(469, 124);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Mật khẩu:";
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
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(182, 121);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(273, 23);
            txtPhoneNumber.TabIndex = 5;
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
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(62, 164);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(46, 15);
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
            // frm_ChinhSuaSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 411);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_ChinhSuaSanPham";
            Text = "frm_ChinhSuaSanPham";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txtEmail;
        private Button btn_Cancel;
        private Label lblUserName;
        private Button btn_Save;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblPhoneNumber;
        private ComboBox cmbRole;
        private TextBox txtPhoneNumber;
        private Label lblRole;
        private Label lblName;
        private TextBox txtName;
        private Label lblAddress;
        private TextBox txtAddress;
    }
}