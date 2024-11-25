// View/UserControlCustom/Navbar_Left.cs
using System;
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
        // Các sự kiện đã được định nghĩa sẵn
        public event EventHandler QuanLyLapRapClicked;
        public event EventHandler QuanLyKhoClicked;
        public event EventHandler QuanLyTaiKhoanClicked;
        public event EventHandler QuanLyDonHangClicked;
        public event EventHandler DeXuatCauHinhClicked;
        public event EventHandler QuanLySanPhamClicked;
        public event EventHandler LichSuGiaoDichClicked;
        public event EventHandler BaoCaoThongKeClicked;

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

        private void btn_DeXuatCauHinh_Click(object sender, EventArgs e)
        {
            DeXuatCauHinhClicked?.Invoke(this, e);
        }

        private void btn_QuanLySanPham_Click(object sender, EventArgs e)
        {
            QuanLySanPhamClicked?.Invoke(this, e);
        }

        private void btn_LichSuGiaoDich_Click(object sender, EventArgs e)
        {
            LichSuGiaoDichClicked?.Invoke(this, e);
        }

        private void btn_BaoCaoThongKe_Click(object sender, EventArgs e)
        {
            BaoCaoThongKeClicked?.Invoke(this, e);
        }

        // Thêm các sự kiện mới cho avatar và logout
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Toggle visibility của panelLogout khi nhấn vào avatar
            panelLogout.Visible = !panelLogout.Visible;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Thực hiện đăng xuất
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác Nhận Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void SetUsername(string username)
        {
            label1.Text = username;
        }
    }
}
