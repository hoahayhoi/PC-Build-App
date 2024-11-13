﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.UserControlCustom
{
    public partial class Navbar_Left : UserControl
    {


        public event EventHandler QuanLyLapRapClicked;
        public event EventHandler QuanLyKhoClicked;
        public event EventHandler QuanLyTaiKhoanClicked;
        public event EventHandler QuanLyDonHangClicked;


        public Navbar_Left()
        {
            InitializeComponent();
        }

        private void btn_QuanLyTaiKhoan_Click_1(object sender, EventArgs e)
        {
            QuanLyTaiKhoanClicked?.Invoke(this, e);
        }

        private void btn_QuanLyKho_Click_1(object sender, EventArgs e)
        {
            QuanLyKhoClicked?.Invoke(this, e);
        }

        private void btn_QuanLyLapRap_Click_1(object sender, EventArgs e)
        {
            QuanLyLapRapClicked?.Invoke(this, e);
        }

        private void btn_QuanLyDonHang_Click(object sender, EventArgs e)
        {
            QuanLyDonHangClicked?.Invoke(this, e);
        }
    }
}