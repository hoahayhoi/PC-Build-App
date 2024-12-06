using App.View.QuanLyTaiKhoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.View.QuanLyLapRap
{
    public partial class frm_PhanCongLapRap : Form
    {
        private CustomMenuStripRender _renderer;
        private CustomPermissions phanQuyen;
        DatabaseDataContext db = new DatabaseDataContext(Properties.Settings.Default.PCBuildConnectionString);

        public frm_PhanCongLapRap()
        {
            InitializeComponent();

            _renderer = new CustomMenuStripRender();
            this.menuStrip1.Renderer = _renderer;
            _renderer.CurrentItem = phânCôngLắpRápToolStripMenuItem.Text;

            phanQuyen = new CustomPermissions();
            ApplyPermissions();

            toolStripStatusLabel1.Text += frm_Login.CurrentUserName;

            rdbTatCa.Checked = true;
            LoadAllPhanCong();
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
            QuanLySanPham.QuanLySanPham f = new QuanLySanPham.QuanLySanPham();
            f.Show();
            this.Hide();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang.QuanLyKhachHang frm = new QuanLyKhachHang.QuanLyKhachHang();
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
            QuanLyTaiKhoan.QuanLyTaiKhoan frm = new QuanLyTaiKhoan.QuanLyTaiKhoan();
            frm.Show();
            this.Hide();
        }

        private void quảnLyKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKho.QuanLyKho frm = new QuanLyKho.QuanLyKho();
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

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Main f = new frm_Main();
            this.Hide();
            f.Show();
        }

        private void đơnHàngtoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cấuHìnhtoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýLắpRáptoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhàCungCấptoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêtoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rdbDaPC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDaPC.Checked)
            {
                var phanCong = (from a in db.AssemblyAssignments
                                join u in db.Users on a.TechnicianID equals u.Id
                                join od in db.OrderDetails on a.OrderDetailID equals od.Id
                                select new
                                {
                                    AssignmentID = a.Id,
                                    Tech = u.Name,
                                    AssignedDate = a.AssignedDate,
                                    CompletionDate = a.CompletionDate,
                                    Status = a.Status,
                                    OrderID = od.OrderID,
                                }).ToList();
                dgvPhanCong.DataSource = phanCong;
            }
        }

        private void rdbChuaPC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbChuaPC.Checked)
            {
                var phanCong = (from a in db.AssemblyAssignments
                                join u in db.Users on a.TechnicianID.ToString() equals null
                                join od in db.OrderDetails on a.OrderDetailID equals od.Id
                                select new
                                {
                                    AssignmentID = a.Id,
                                    Tech = "Chưa phân công",
                                    AssignedDate = a.AssignedDate,
                                    CompletionDate = a.CompletionDate,
                                    Status = a.Status,
                                    OrderID = od.OrderID,
                                }).ToList();
                dgvPhanCong.DataSource = phanCong;
            }
        }

        private void LoadAllPhanCong()
        {
            var phanCong = (from a in db.AssemblyAssignments
                            join u in db.Users on a.TechnicianID equals u.Id into users
                            from u in users.DefaultIfEmpty()
                            join od in db.OrderDetails on a.OrderDetailID equals od.Id
                            select new
                            {
                                AssignmentID = a.Id,
                                Tech = u != null ? u.Name : "Chưa phân công",
                                AssignedDate = a.AssignedDate,
                                CompletionDate = a.CompletionDate,
                                Status = a.Status,
                                OrderID = od.OrderID,
                            }).ToList();
            dgvPhanCong.DataSource = phanCong;
        }

        private void rdbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTatCa.Checked)
                LoadAllPhanCong();
        }

        private void SearchAssemblyAssignments(string searchTerm)
        {
            var phanCong = (from a in db.AssemblyAssignments
                           join u in db.Users on a.TechnicianID equals u.Id into users
                            from u in users.DefaultIfEmpty()
                            join od in db.OrderDetails on a.OrderDetailID equals od.Id
                           where u.Name.Contains(searchTerm) ||
                                 od.OrderID.ToString().Contains(searchTerm) ||
                                 a.AssignedDate.ToString().Contains(searchTerm) ||
                                 a.Id.ToString().Contains(searchTerm)
                           select new
                           {
                               AssignmentID = a.Id,
                               Tech = u.Name,
                               AssignedDate = a.AssignedDate,
                               CompletionDate = a.CompletionDate,
                               Status = a.Status,
                               OrderID = od.OrderID,
                           }).ToList();
            dgvPhanCong.DataSource = phanCong;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchTerm = txtSearch.Text.Trim().ToLower();
                SearchAssemblyAssignments(searchTerm);
            }
        }
    }
}
