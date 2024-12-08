using System;
using System.Windows.Forms;
using App.Controller;

namespace App.View.QuanLyTaiKhoan
{
    public partial class DoiMatKhau : Form
    {
        private readonly UserController _userController;
        private int currentUserId; // Giả sử bạn đã lưu ID người dùng hiện tại

        public DoiMatKhau(int userId)
        {
            InitializeComponent();
            _userController = new UserController();
            currentUserId = userId; // Lưu ID người dùng hiện tại
            LoadUserInfo();
        }

        // Load thông tin người dùng vào panel trái
        private void LoadUserInfo()
        {
            var user = _userController.GetUserById(currentUserId);
            if (user != null)
            {
                lblUserName.Text = "Username: " + user.UserName;
                lblEmail.Text = "Email: " + user.Email;
                lblPhone.Text = "Phone: " + user.Phone;
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        // Khi người dùng nhấn nút đổi mật khẩu
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Kiểm tra mật khẩu mới và xác nhận mật khẩu
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }

            // Gọi controller để thực hiện việc thay đổi mật khẩu
            bool result = _userController.ChangePassword(currentUserId, currentPassword, newPassword);

            if (result)
            {
                MessageBox.Show("Password changed successfully.");
                // Clear the textboxes after success
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }
            else
            {
                MessageBox.Show("Current password is incorrect or an error occurred.");
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            // Ẩn cửa sổ hiện tại
            this.Hide();

            // Tạo và hiển thị lại form chính (hoặc form trang chủ)
            frm_Main homeForm = new frm_Main(); // Giả sử bạn có một form trang chủ tên là FormHome
            homeForm.Show();  // Hiển thị form trang chủ

            // Nếu bạn muốn đóng form hiện tại thay vì chỉ ẩn, bạn có thể sử dụng:
            // this.Close();
        }
    }
}
