using PcBuiApp_Client_v1.UserControlCustom;
using PcBuiApp_Client_v1.View.DeXuatCauHinh;
using PcBuiApp_Client_v1.View.QuanLyBaoCaoThongKe;
using PcBuiApp_Client_v1.View.QuanLySanPham;
using PcBuiApp_Client_v1.View.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            navbar_Left1.DeXuatCauHinhClicked += navbar_Left1_DeXuatCauHinhClicked;
            navbar_Left1.QuanLySanPhamClicked += navbar_Left1_QuanLySanPhamClicked;
            navbar_Left1.LichSuGiaoDichClicked += navbar_Left1_LichSuGiaoDichClicked;
            navbar_Left1.BaoCaoThongKeClicked += navbar_Left1_BaoCaoThongKeClicked;
            navbar_Left1.TrangChuClicked += navbar_Left1_TrangChuClicked;
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

        // Xử lý sự kiện khi click vào nút "Đề Xuất Cấu Hình"
        private void navbar_Left1_DeXuatCauHinhClicked(object sender, EventArgs e)
        {
            var deXuatCauHinhForm = new frm_dexuatcauhinh();
            ShowFormInPanel(deXuatCauHinhForm);
        }

        // Xử lý sự kiện khi click vào nút "Quan Ly San Pham"
        private void navbar_Left1_QuanLySanPhamClicked(object sender, EventArgs e)
        {
            var quanLySanPhamForm = new frm_QuanLySanPham();
            ShowFormInPanel(quanLySanPhamForm);
        }

        // Xử lý sự kiện khi click vào nút "Lich Su Giao Dich"
        private void navbar_Left1_LichSuGiaoDichClicked(object sender, EventArgs e)
        {
            var lichSuGiaoDichForm = new frm_QuanLyLSGD();
            ShowFormInPanel(lichSuGiaoDichForm);
        }
        
        private void navbar_Left1_BaoCaoThongKeClicked(object sender, EventArgs e)
        {
            var baocaothongkeForm = new frm_BaoCaoThongKe();
            ShowFormInPanel(baocaothongkeForm);
        }


        private void btn_CloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navbar_Left1_TrangChuClicked(object sender, EventArgs e)
        {
            var main = new frm_Main();
            ShowFormInPanel(main);
        }

        public void SetUsername(string username)
        {
            this.navbar_Left1.SetUsername(username);
        }

    }
}
