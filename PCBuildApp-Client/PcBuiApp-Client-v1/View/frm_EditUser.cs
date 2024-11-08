// frm_EditUser.cs
using PcBuiApp_Client_v1.Controllers;
using PcBuiApp_Client_v1.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PcBuiApp_Client_v1.View
{
    public partial class frm_EditUser : Form
    {
        private UserController userController;
        private AppUser currentUser;

        public frm_EditUser(AppUser user)
        {
            InitializeComponent();
            userController = new UserController();
            currentUser = user;

            // Hiển thị thông tin người dùng trên form
            txtUserName.Text = currentUser.UserName;
            txtEmail.Text = currentUser.Email;
            txtPhoneNumber.Text = currentUser.PhoneNumber;
            txtName.Text = currentUser.Name;
            cmbRole.SelectedItem = currentUser.Role;    

            // Không cho phép chỉnh sửa tên đăng nhập
            txtUserName.ReadOnly = true;
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            // Cập nhật thông tin người dùng
            currentUser.Email = txtEmail.Text.Trim();
            currentUser.PhoneNumber = txtPhoneNumber.Text.Trim();
            currentUser.Name = txtName.Text.Trim();
            currentUser.Role = cmbRole.SelectedItem.ToString();

            // Gọi API để cập nhật người dùng
            try
            {
                await userController.UpdateUserAsync(currentUser);
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
