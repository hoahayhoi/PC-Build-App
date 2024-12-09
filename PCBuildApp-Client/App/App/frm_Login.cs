using App.Controller;
using App.Helper;
using App.Model;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App
{
    public partial class frm_Login : MaterialForm
    {
        public static string CurrentUserRole;
        public static string CurrentUserID;
        public static string CurrentUserName;

        public frm_Login()
        {
            InitializeComponent();

            // Đăng ký sự kiện đăng nhập thành công
            loginUserControl1.LoginSuccessful += LoginUserControl_LoginSuccessful;
        }

        private void LoginUserControl_LoginSuccessful(object sender, EventArgs e)
        {
            // Khi đăng nhập thành công, lấy thông tin người dùng từ LoginUserControl
            CurrentUserRole = LoginUserControl.CurrentUserRole;
            CurrentUserID = LoginUserControl.CurrentUserID;
            CurrentUserName = LoginUserControl.CurrentUserName;

            // Thực hiện các hành động sau khi đăng nhập thành công
            MessageBox.Show("Đăng nhập thành công!");

            // Ví dụ, mở form chính sau khi đăng nhập thành công
            frm_Main mainForm = new frm_Main();
            mainForm.Show();
            this.Hide();  // Ẩn form đăng nhập
        }
    }
}
