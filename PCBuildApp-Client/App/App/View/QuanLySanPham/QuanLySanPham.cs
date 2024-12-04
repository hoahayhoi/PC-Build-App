﻿using MaterialSkin;
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
    public partial class QuanLySanPham : MaterialForm
    {
        private CustomMenuStripRender _renderer;
        public QuanLySanPham()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.Blue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            _renderer = new CustomMenuStripRender();
            this.menuStrip1.Renderer = _renderer;
            _renderer.CurrentItem = trangChủToolStripMenuItem.Text;
        }

    }
}
