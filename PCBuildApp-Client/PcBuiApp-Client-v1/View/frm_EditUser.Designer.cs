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
        private Button btn_Save;
        private Button btn_Cancel;

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
            this.lblUserName = new Label();
            this.txtUserName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPhoneNumber = new Label();
            this.txtPhoneNumber = new TextBox();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblRole = new Label();
            this.cmbRole = new ComboBox();
            this.btn_Save = new Button();
            this.btn_Cancel = new Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(30, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(85, 15);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tên đăng nhập:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(150, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.ReadOnly = true; // Không cho phép chỉnh sửa
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(30, 110);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(77, 15);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(150, 107);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(250, 23);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Họ và Tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 7;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(30, 190);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 15);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Vai trò:";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "SalesStaff",
            "Technician",
            "User"});
            this.cmbRole.Location = new System.Drawing.Point(150, 187);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(250, 23);
            this.cmbRole.TabIndex = 9;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(150, 240);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 30);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += btn_Save_Click;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(300, 240);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 30);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += btn_Cancel_Click;
            // 
            // frm_EditUser
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Name = "frm_EditUser";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Chỉnh Sửa Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
