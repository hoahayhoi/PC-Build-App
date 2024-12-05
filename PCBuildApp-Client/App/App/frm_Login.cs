using App.Controller;
using App.Helper;
using App.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class frm_Login : MaterialForm
    {
        DatabaseDataContext db = new DatabaseDataContext(Properties.Settings.Default.PCBuildConnectionString);
        public static string CurrentUserRole;
        public static string CurrentUserID;

        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
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

                var accountController = new AccountController();
                if (accountController.Login(loginDto))
                {
                    // Lấy role của user
                    string roleQuery = @"SELECT u.Id as UserID, r.Name as Role 
                               FROM Users u
                               JOIN UserRoles ur ON u.Id = ur.UserId
                               JOIN Roles r ON ur.RoleId = r.Id
                               WHERE u.UserName = @username";

                    using SqlCommand cmd = new SqlCommand(roleQuery, conn);
                    cmd.Parameters.AddWithValue("@username", loginDto.Username);
                    using SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["Role"].ToString();
                        string userID = reader["UserID"].ToString();
                        CurrentUserRole = role;
                        CurrentUserID = userID;
                        var mainForm = new frm_Main();
                        mainForm.Show();
                        this.Hide();
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

        private void LoadLoginInfo()
        {
            if (Properties.Settings.Default.RememberLogin)
            {
                txtTenDN.Text = Properties.Settings.Default.Username;
                txtMK.Text = Properties.Settings.Default.Password;
                ckbNhoMK.Checked = true;
            }
        }

        private void ckbNhoMK_CheckedChanged(object sender, EventArgs e)
        {
            SaveLoginInfo(ckbNhoMK.Checked);
        }
    }
}
