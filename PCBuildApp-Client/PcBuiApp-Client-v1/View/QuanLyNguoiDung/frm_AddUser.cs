// frm_AddUser.cs
using PcBuiApp_Client_v1.Controllers;
using PcBuiApp_Client_v1.Models;
using System;
using System.Windows.Forms;

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
            try
            {
                var user = new AppUser
                {
                    name = txtName.Text,
                    email = txtEmail.Text,
                    phone = txtPhoneNumber.Text,
                    address = txtAddress.Text
                };

                await userController.AddUserAsync(user);
                MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
