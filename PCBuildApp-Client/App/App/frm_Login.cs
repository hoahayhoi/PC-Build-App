using App.Controller;
using App.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                var role = (from u in db.Users
                           join ur in db.UserRoles on u.Id equals ur.UserId
                           join r in db.Roles on ur.RoleId equals r.Id
                           select new { Role = r.Name }).FirstOrDefault();
                CurrentUserRole = role.Role.ToString();

                var loginDto = new LoginDto
                {
                    Username = txtTenDN.Text.Trim(),
                    Password = txtMK.Text.Trim()
                };

                var accountController = new AccountController();
                if (accountController.Login(loginDto))
                {
                    var mainForm = new frm_Main();
                    mainForm.Show();
                    this.Hide();
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
