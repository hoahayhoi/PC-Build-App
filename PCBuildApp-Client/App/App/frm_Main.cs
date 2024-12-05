using App.View.QuanLyKhachHang;
using App.View.QuanLySanPham;
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
    }
}
