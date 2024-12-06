using App.View.QuanLyKhachHang;
using App.View.QuanLyKho;
using App.View.QuanLyLapRap;
using App.View.QuanLySanPham;
using App.View.QuanLyTaiKhoan;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace App
{
    public partial class frm_Main : Form
    {
        private CustomMenuStripRender _renderer;
        private CustomPermissions phanQuyen;

        public frm_Main()
        {
            InitializeComponent();

            _renderer = new CustomMenuStripRender();
            this.menuStrip1.Renderer = _renderer;
            _renderer.CurrentItem = trangChủToolStripMenuItem.Text;

            phanQuyen = new CustomPermissions();
            ApplyPermissions();
        }

        private void ApplyPermissions()
        {
            foreach (ToolStripMenuItem item in this.menuStrip1.Items)
            {
                item.Visible = phanQuyen.permissions[frm_Login.CurrentUserRole].Contains(item.Text);
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySanPham f = new QuanLySanPham();
            f.Show();
            this.Hide();
        }

        private void frm_Main_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang frm = new QuanLyKhachHang();
            frm.Show();
            this.Hide();

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau frm = new DoiMatKhau(int.Parse(frm_Login.CurrentUserID));
            frm.Show();
            this.Hide();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan frm = new QuanLyTaiKhoan();
            frm.Show();
            this.Hide();
        }

        private void quảnLyKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKho frm = new QuanLyKho();
            frm.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();

                this.Hide();  // Ẩn cửa sổ chính
                frm_Login loginForm = new frm_Login();
                loginForm.Show();  // Mở lại form đăng nhập
            }
        }

        private void phânCôngLắpRápToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PhanCongLapRap f = new frm_PhanCongLapRap();
            this.Hide();
            f.Show();
        }
    }
}
