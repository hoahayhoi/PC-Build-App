using System;
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
        }

        private void ShowFormInPanel(Form form)
        {
            panelMain.Controls.Clear(); // Xóa các control cũ trong panel
            form.TopLevel = false; // Set form không phải là top-level
            form.FormBorderStyle = FormBorderStyle.None; // Ẩn viền form
            form.Dock = DockStyle.Fill; // Đổ form vào toàn bộ panel
            panelMain.Controls.Add(form); // Thêm form vào panel
            form.Show(); // Hiển thị form
        }


        private void btn_CloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_QuanLyKho_Click(object sender, EventArgs e)
        {
            var formKho = new frm_QuanLyKho(); // Tạo instance của form
            ShowFormInPanel(formKho); // Hiển thị form vào panel
        }

        private void btn_QuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            var formQuanLyTaiKhoan = new frm_QuanLyNhanVien(); // Tạo instance của form
            ShowFormInPanel(formQuanLyTaiKhoan); // Hiển thị form vào panel
        }

        private void btn_QuanLyLapRap_Click(object sender, EventArgs e)
        {
            var formQuanLyLapRap = new frm_QuanLyLapRap(); // Tạo instance của form
            ShowFormInPanel(formQuanLyLapRap); // Hiển thị form vào panel
        }
    }
}
