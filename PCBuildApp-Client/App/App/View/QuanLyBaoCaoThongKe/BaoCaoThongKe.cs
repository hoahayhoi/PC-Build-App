using System;
using System.Windows.Forms;
using App.Controller;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace App.View.QuanLyBaoCaoThongKe
{
    public partial class BaoCaoThongKe : Form
    {
        private readonly ReportController _reportController;

        public BaoCaoThongKe()
        {
            InitializeComponent();
            _reportController = new ReportController();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Khởi tạo combobox năm
            for (int year = DateTime.Now.Year; year >= 2020; year--)
            {
                cboNam.Items.Add(year);
            }
            cboNam.SelectedIndex = 0;

            // Khởi tạo DateTimePicker
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;

            // Đăng ký event handlers
            btnXemDoanhThu.Click += BtnXemDoanhThu_Click;
            btnXemSanPham.Click += BtnXemSanPham_Click;
            btnCapNhatTonKho.Click += BtnCapNhatTonKho_Click;

            btnXuatExcelDoanhThu.Click += BtnXuatExcelDoanhThu_Click;
            btnXuatExcelSanPham.Click += BtnXuatExcelSanPham_Click;
            btnXuatExcelTonKho.Click += BtnXuatExcelTonKho_Click;

            // Style cho DataGridViews
            StyleDataGridView(dgvDoanhThu);
            StyleDataGridView(dgvSanPham);
            StyleDataGridView(dgvTonKho);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(167)))), ((int)(((byte)(221)))));
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
        }

        private void ExportToExcel(DataGridView dgv, string title)
        {
            try
            {
                dgv.SelectAll();
                DataObject dataObj = dgv.GetClipboardContent();
                if (dataObj != null)
                {
                    Clipboard.SetDataObject(dataObj);

                    Excel.Application xlexcel = new Excel.Application();
                    Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(Type.Missing);
                    Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    // Tiêu đề báo cáo
                    Excel.Range rng = xlWorkSheet.get_Range("A1", "E1");
                    rng.Merge();
                    rng.Value2 = title;
                    rng.Font.Bold = true;
                    rng.Font.Size = 16;
                    rng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    // Dữ liệu
                    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[3, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                    // Định dạng
                    xlWorkSheet.Columns.AutoFit();
                    Excel.Range dataRange = xlWorkSheet.UsedRange;
                    dataRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                    // Hiển thị Excel
                    xlexcel.Visible = true;

                    // Cleanup
                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlexcel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Clipboard.Clear();
            }
        }

        private void BtnXemDoanhThu_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedYear = (int)cboNam.SelectedItem;
                var data = _reportController.GetMonthlyRevenue(selectedYear);
                dgvDoanhThu.DataSource = data;
                FormatDoanhThuGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu doanh thu: {ex.Message}");
            }
        }

        private void BtnXemSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                var data = _reportController.GetTopSellingProducts(dtpStartDate.Value, dtpEndDate.Value);
                dgvSanPham.DataSource = data;
                FormatSanPhamGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu sản phẩm: {ex.Message}");
            }
        }

        private void BtnCapNhatTonKho_Click(object sender, EventArgs e)
        {
            try
            {
                var data = _reportController.GetInventoryValue();
                dgvTonKho.DataSource = data;
                FormatTonKhoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu tồn kho: {ex.Message}");
            }
        }

        private void BtnXuatExcelDoanhThu_Click(object sender, EventArgs e)
        {
            if (dgvDoanhThu.Rows.Count > 0)
            {
                ExportToExcel(dgvDoanhThu, $"Báo Cáo Doanh Thu Năm {cboNam.SelectedItem}");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnXuatExcelSanPham_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.Rows.Count > 0)
            {
                ExportToExcel(dgvSanPham, $"Báo Cáo Sản Phẩm Bán Chạy ({dtpStartDate.Value.ToShortDateString()} - {dtpEndDate.Value.ToShortDateString()})");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnXuatExcelTonKho_Click(object sender, EventArgs e)
        {
            if (dgvTonKho.Rows.Count > 0)
            {
                ExportToExcel(dgvTonKho, $"Báo Cáo Tồn Kho (Ngày {DateTime.Now.ToShortDateString()})");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormatDoanhThuGrid()
        {
            dgvDoanhThu.Columns["Revenue"].DefaultCellStyle.Format = "N0";
            dgvDoanhThu.Columns["Month"].HeaderText = "Tháng";
            dgvDoanhThu.Columns["TotalOrders"].HeaderText = "Số đơn hàng";
            dgvDoanhThu.Columns["Revenue"].HeaderText = "Doanh thu";
            dgvDoanhThu.Columns["TotalItems"].HeaderText = "Số sản phẩm";
        }

        private void FormatSanPhamGrid()
        {
            dgvSanPham.Columns["TotalRevenue"].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns["TotalQuantity"].HeaderText = "Số lượng bán";
            dgvSanPham.Columns["TotalRevenue"].HeaderText = "Doanh thu";
        }

        private void FormatTonKhoGrid()
        {
            dgvTonKho.Columns["TotalValue"].DefaultCellStyle.Format = "N0";
            dgvTonKho.Columns["CategoryName"].HeaderText = "Danh mục";
            dgvTonKho.Columns["TotalProducts"].HeaderText = "Số sản phẩm";
            dgvTonKho.Columns["TotalStock"].HeaderText = "Tổng tồn kho";
            dgvTonKho.Columns["TotalValue"].HeaderText = "Giá trị tồn kho";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            // Ẩn cửa sổ hiện tại
            this.Hide();

            // Tạo và hiển thị lại form chính (hoặc form trang chủ)
            frm_Main homeForm = new frm_Main(); // Giả sử bạn có một form trang chủ tên là FormHome
            homeForm.Show();  // Hiển thị form trang chủ

            // Nếu bạn muốn đóng form hiện tại thay vì chỉ ẩn, bạn có thể sử dụng:
            // this.Close();
        }
    }
}