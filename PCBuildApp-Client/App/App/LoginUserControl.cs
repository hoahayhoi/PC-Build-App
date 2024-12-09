using App.Controller;
using App.Helper;
using App.Model;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App
{
    public partial class LoginUserControl : UserControl
    {
        private readonly AccountController _accountController;
        public event EventHandler LoginSuccessful;

        // Các biến tĩnh để lưu thông tin người dùng
        public static string CurrentUserRole;
        public static string CurrentUserID;
        public static string CurrentUserName;

        public LoginUserControl()
        {
            InitializeComponent();
            _accountController = new AccountController();
            LoadLoginInfo();
        }

        private async void btnDN_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = BackendHelper.GetConnection();
                conn.Open();

                var loginDto = new LoginDto
                {
                    Username = txtTenDN.Text.Trim(),
                    Password = txtMK.Text.Trim()
                };

                if (_accountController.Login(loginDto))
                {
                    string roleQuery = @"SELECT u.Id as UserID, r.Name as Role, u.UserName 
                               FROM Users u
                               JOIN UserRoles ur ON u.Id = ur.UserId
                               JOIN Roles r ON ur.RoleId = r.Id
                               WHERE u.UserName = @username";

                    using SqlCommand cmd = new SqlCommand(roleQuery, conn);
                    cmd.Parameters.AddWithValue("@username", loginDto.Username);
                    using SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Lưu thông tin người dùng vào các biến tĩnh để có thể sử dụng ở chỗ khác
                        CurrentUserRole = reader["Role"].ToString();
                        CurrentUserID = reader["UserID"].ToString();
                        CurrentUserName = reader["UserName"].ToString();

                        // Kích hoạt sự kiện đăng nhập thành công
                        LoginSuccessful?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản chưa được phân quyền");
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadLoginInfo()
        {
            if (Properties.Settings.Default.RememberLogin)
            {
                txtTenDN.Text = Properties.Settings.Default.Username;
                txtMK.Text = Properties.Settings.Default.Password;
                ckbNhoMK.Checked = true;
            }
        }

        private void SaveLoginInfo(bool remember)
        {
            if (remember)
            {
                Properties.Settings.Default.Username = txtTenDN.Text;
                Properties.Settings.Default.Password = txtMK.Text;
                Properties.Settings.Default.RememberLogin = true;
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberLogin = false;
            }
            Properties.Settings.Default.Save();
        }

        private void ckbNhoMK_CheckedChanged(object sender, EventArgs e)
        {
            SaveLoginInfo(ckbNhoMK.Checked);
        }
    }
}
