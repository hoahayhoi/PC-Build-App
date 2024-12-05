using App.View.QuanLyKhachHang;
using MaterialSkin;
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

namespace App.View.QuanLySanPham
{
    public partial class QuanLySanPham : Form
    {
        private CustomMenuStripRender _renderer;
        private CustomPermissions phanQuyen;

        public QuanLySanPham()
        {
            InitializeComponent();

            _renderer = new CustomMenuStripRender();
            this.menuStrip1.Renderer = _renderer;
            _renderer.CurrentItem = sảnPhẩmToolStripMenuItem.Text;

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

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Main f = new frm_Main();
            f.Show();
            this.Hide();
        }

        private void QuanLySanPham_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang.QuanLyKhachHang f = new QuanLyKhachHang.QuanLyKhachHang();
            f.Show();
            this.Hide();
        }
    }
}
