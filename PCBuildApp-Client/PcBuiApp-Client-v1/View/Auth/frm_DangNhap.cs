using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcBuiApp_Client_v1.Controller;
using PcBuiApp_Client_v1.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcBuiApp_Client_v1.UserControlCustom;

namespace PcBuiApp_Client_v1.View
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string username = textBox_UserName.Text.Trim();
            string password = textBox_Password.Text.Trim();

            // Kiểm tra thông tin đăng nhập
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBox_ForgotPassword.Checked)
            {
                Properties.Settings.Default.Username = username;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.Save();
            }


            // Tạo đối tượng LoginDto
            var loginDto = new LoginDto
            {
                Username = username,
                Password = password
            };

            // Gọi phương thức đăng nhập từ AccountController
            var accountController = new AccountController();
            try
            {
                var userResponse = await accountController.LoginAsync(loginDto);

                // Lưu token vào đâu đó nếu cần (ví dụ: biến toàn cục, Settings, etc.)
                string token = userResponse.Token;

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Mở form chính của ứng dụng
                var mainForm = new frm_QuanLyChinh(); // Giả sử bạn có form chính tên là MainForm
                mainForm.SetUsername(username);
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            textBox_UserName.Text = Properties.Settings.Default.Username;
            textBox_Password.Text = Properties.Settings.Default.Password;
            checkBox_ForgotPassword.Checked = !string.IsNullOrEmpty(Properties.Settings.Default.Username);
        }
    }
}
