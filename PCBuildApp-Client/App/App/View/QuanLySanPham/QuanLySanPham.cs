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
        public QuanLySanPham()
        {
            InitializeComponent();

            _renderer = new CustomMenuStripRender();
            this.menuStrip1.Renderer = _renderer;
            _renderer.CurrentItem = sảnPhẩmToolStripMenuItem.Text;
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
    }
}
