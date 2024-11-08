// frm_AddUser.cs
using PcBuiApp_Client_v1.Controllers;
using PcBuiApp_Client_v1.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PcBuiApp_Client_v1.View
{
    public partial class frm_AddUser : Form
    {
        private UserController userController;

        public frm_AddUser()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            // Thu thập thông tin từ các TextBox
            var newUser = new AppUser
            {
                UserName = txtUserName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Name = txtName.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString(),
                Password = txtPassword.Text.Trim()
            };

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(newUser.UserName) ||
                string.IsNullOrEmpty(newUser.Email) ||
                string.IsNullOrEmpty(newUser.Password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi API để thêm người dùng
            try
            {
                await userController.AddUserAsync(newUser);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
