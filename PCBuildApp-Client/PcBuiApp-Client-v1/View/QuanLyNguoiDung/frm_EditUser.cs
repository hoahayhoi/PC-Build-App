// frm_AddUser.cs
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
            LoadUserData();
        }

        private void LoadUserData()
        {
            txtName.Text = currentUser.name;
            txtEmail.Text = currentUser.email;
            txtPhoneNumber.Text = currentUser.phone;
            txtAddress.Text = currentUser.address;
        }


        private async void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                currentUser.name = txtName.Text;
                currentUser.email = txtEmail.Text;
                currentUser.phone = txtPhoneNumber.Text;
                currentUser.address = txtAddress.Text;

                await userController.UpdateUserAsync(currentUser);
                MessageBox.Show("Cập nhật người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
