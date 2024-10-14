﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.View
{
    public partial class frm_QuanLyChinh : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public frm_QuanLyChinh()
        {
            InitializeComponent();

            navbar_Left1.QuanLyLapRapClicked += Navbar_Left1_QuanLyLapRapClicked;
            navbar_Left1.QuanLyKhoClicked += Navbar_Left1_QuanLyKhoClicked;
            navbar_Left1.QuanLyTaiKhoanClicked += Navbar_Left1_QuanLyTaiKhoanClicked;
            navbar_Left1.QuanLyDonHangClicked += navbar_Left1_QuanLyDonHangClicked;
        }

        // Phương thức hiển thị form trong panel
        private void ShowFormInPanel(Form form)
        {
            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        // Xử lý sự kiện khi click vào nút "Quản Lý Lắp Ráp"
        private void Navbar_Left1_QuanLyLapRapClicked(object sender, EventArgs e)
        {
            var lapRapForm = new frm_QuanLyLapRap();
            ShowFormInPanel(lapRapForm);
        }

        // Xử lý sự kiện khi click vào nút "Quản Lý Đơn hàng"
        private void navbar_Left1_QuanLyDonHangClicked(object sender, EventArgs e)
        {
            var donhangForm = new frm_QuanLyDonHang();
            ShowFormInPanel(donhangForm);
        }
        // Xử lý sự kiện khi click vào nút "Quản Lý Kho"
        private void Navbar_Left1_QuanLyKhoClicked(object sender, EventArgs e)
        {
            var khoForm = new frm_QuanLyKho();
            ShowFormInPanel(khoForm);
        }

        // Xử lý sự kiện khi click vào nút "Quản Lý Tài Khoản"
        private void Navbar_Left1_QuanLyTaiKhoanClicked(object sender, EventArgs e)
        {
            var taiKhoanForm = new frm_QuanLyNhanVien();
            ShowFormInPanel(taiKhoanForm);
        }


        private void btn_CloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
