// View/QuanLyBaoCaoThongKe/frm_BaoCaoThongKe.cs
using Newtonsoft.Json;
using PcBuiApp_Client_v1.Controller;
using PcBuiApp_Client_v1.Controllers;
using PcBuiApp_Client_v1.Model;
using PcBuiApp_Client_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.View.QuanLyBaoCaoThongKe
{
    public partial class frm_BaoCaoThongKe : Form
    {
        private ProductController productController;
        private ReportController reportController;

        public frm_BaoCaoThongKe()
        {
            InitializeComponent();
            this.Load += Frm_BaoCaoThongKe_Load;

            // Khởi tạo controller
            productController = new ProductController();
            reportController = new ReportController();

            // Gắn sự kiện cho các nút báo cáo
            btn_DoanhThuThang.Click += Btn_DoanhThuThang_Click;
            btn_TonKhoSanPham.Click += Btn_TonKhoSanPham_Click;
            btn_DonHangTrangThai.Click += Btn_DonHangTrangThai_Click;
            btn_BaoCaoBaoHanhThang.Click += Btn_BaoCaoBaoHanhThang_Click;
            btn_NhapHangNhaCungCap.Click += Btn_NhapHangNhaCungCap_Click;
            btn_CloseLogin.Click += Btn_CloseLogin_Click;
        }

        private void Btn_CloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Frm_BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            // Tùy chọn: Tải báo cáo mặc định
            await LoadDoanhThuThang();
        }

        // 1. Doanh Thu Theo Tháng
        private async void Btn_DoanhThuThang_Click(object sender, EventArgs e)
        {
            await LoadDoanhThuThang();
        }

        private async Task LoadDoanhThuThang()
        {
            try
            {
                var doanhThuThang = await reportController.GetDoanhThuThangAsync();
                dataGridView_Report.DataSource = doanhThuThang;

                // Tùy chỉnh DataGridView
                dataGridView_Report.Columns["Year"].HeaderText = "Năm";
                dataGridView_Report.Columns["Month"].HeaderText = "Tháng";
                dataGridView_Report.Columns["TotalRevenue"].HeaderText = "Doanh Thu";

                // Định dạng số tiền
                dataGridView_Report.Columns["TotalRevenue"].DefaultCellStyle.Format = "C0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Báo Cáo Doanh Thu Tháng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Tồn Kho Sản Phẩm
        private async void Btn_TonKhoSanPham_Click(object sender, EventArgs e)
        {
            await LoadTonKhoSanPham();
        }

        private async Task LoadTonKhoSanPham()
        {
            try
            {
                // Gọi API để lấy danh sách sản phẩm
                var products = await productController.GetProductsAsync();

                // Lọc sản phẩm có số lượng tồn kho < 10
                var tonKhoSanPham = products
                    .Where(p => p.stock < 10)
                    .Select(p => new
                    {
                        p.id,
                        p.name,
                        p.category,
                        p.price,
                        p.stock
                    })
                    .OrderBy(p => p.stock)
                    .ToList();

                dataGridView_Report.DataSource = tonKhoSanPham;

                // Tùy chỉnh DataGridView
                dataGridView_Report.Columns["id"].HeaderText = "Mã Sản Phẩm";
                dataGridView_Report.Columns["name"].HeaderText = "Tên Sản Phẩm";
                dataGridView_Report.Columns["category"].HeaderText = "Danh Mục";
                dataGridView_Report.Columns["price"].HeaderText = "Giá Tiền";
                dataGridView_Report.Columns["stock"].HeaderText = "Số Lượng Tồn";

                // Định dạng số tiền
                dataGridView_Report.Columns["price"].DefaultCellStyle.Format = "C0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Báo Cáo Tồn Kho Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Đơn Hàng Theo Trạng Thái
        private async void Btn_DonHangTrangThai_Click(object sender, EventArgs e)
        {
            await LoadDonHangTheoTrangThai();
        }

        private async Task LoadDonHangTheoTrangThai()
        {
            try
            {
                string url = "api/orders";
                using (HttpResponseMessage response = await PcBuiApp_Client_v1.Helpers.ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var orders = JsonConvert.DeserializeObject<List<Order>>(result);

                        var donHangTheoTrangThai = orders
                            .GroupBy(o => o.status)
                            .Select(g => new DonHangTrangThai
                            {
                                Status = g.Key,
                                TotalOrders = g.Count()
                            })
                            .ToList();

                        dataGridView_Report.DataSource = donHangTheoTrangThai;

                        // Tùy chỉnh DataGridView
                        dataGridView_Report.Columns["Status"].HeaderText = "Trạng Thái Đơn Hàng";
                        dataGridView_Report.Columns["TotalOrders"].HeaderText = "Tổng Số Đơn";
                    }
                    else
                    {
                        throw new Exception("Không thể lấy danh sách đơn hàng.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Báo Cáo Đơn Hàng Theo Trạng Thái", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Báo Cáo Bảo Hành Theo Tháng
        private async void Btn_BaoCaoBaoHanhThang_Click(object sender, EventArgs e)
        {
            await LoadBaoCaoBaoHanhThang();
        }

        private async Task LoadBaoCaoBaoHanhThang()
        {
            try
            {
                // Giả sử bạn có API để lấy danh sách bảo hành
                string url = "api/warranties"; // Thay thế bằng API thực tế
                using (HttpResponseMessage response = await PcBuiApp_Client_v1.Helpers.ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var warranties = JsonConvert.DeserializeObject<List<Warranty>>(result);

                        var baoHanhThang = warranties
                            .GroupBy(w => new { w.start_date.Year, w.start_date.Month, w.warranty_type })
                            .Select(g => new
                            {
                                Year = g.Key.Year,
                                Month = g.Key.Month,
                                WarrantyType = g.Key.warranty_type,
                                TotalWarranties = g.Count()
                            })
                            .OrderBy(o => o.Year).ThenBy(o => o.Month)
                            .ToList();

                        dataGridView_Report.DataSource = baoHanhThang;

                        // Tùy chỉnh DataGridView
                        dataGridView_Report.Columns["Year"].HeaderText = "Năm";
                        dataGridView_Report.Columns["Month"].HeaderText = "Tháng";
                        dataGridView_Report.Columns["WarrantyType"].HeaderText = "Loại Bảo Hành";
                        dataGridView_Report.Columns["TotalWarranties"].HeaderText = "Số Lượng Bảo Hành";
                    }
                    else
                    {
                        throw new Exception("Không thể lấy danh sách bảo hành.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Báo Cáo Bảo Hành Theo Tháng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5. Nhập Hàng Theo Nhà Cung Cấp
        private async void Btn_NhapHangNhaCungCap_Click(object sender, EventArgs e)
        {
            await LoadNhapHangNhaCungCap();
        }

        private async Task LoadNhapHangNhaCungCap()
        {
            try
            {
                // Gọi API để lấy danh sách đơn nhập hàng
                string url = "api/purchaseOrders"; // Thay thế bằng API thực tế
                using (HttpResponseMessage response = await PcBuiApp_Client_v1.Helpers.ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var purchaseOrders = JsonConvert.DeserializeObject<List<PurchaseOrder>>(result);

                        // Lấy danh sách nhà cung cấp
                        var suppliers = await GetSuppliersAsync();

                        var nhapHangNhaCungCap = purchaseOrders
                            .GroupBy(po => po.supplierID)
                            .Select(g => new
                            {
                                SupplierName = suppliers.FirstOrDefault(s => s.id == g.Key)?.name ?? "Unknown",
                                TotalImportValue = g.Sum(po => po.purchaseOrderDetails.Sum(pod => pod.total_price))
                            })
                            .ToList();

                        dataGridView_Report.DataSource = nhapHangNhaCungCap;

                        // Tùy chỉnh DataGridView
                        dataGridView_Report.Columns["SupplierName"].HeaderText = "Tên Nhà Cung Cấp";
                        dataGridView_Report.Columns["TotalImportValue"].HeaderText = "Giá Trị Nhập Hàng";

                        // Định dạng số tiền
                        dataGridView_Report.Columns["TotalImportValue"].DefaultCellStyle.Format = "C0";
                    }
                    else
                    {
                        throw new Exception("Không thể lấy danh sách đơn nhập hàng.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Báo Cáo Nhập Hàng Theo Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<List<Supplier>> GetSuppliersAsync()
        {
            try
            {
                var suppliers = await new SupplierController().GetSuppliersAsync();
                return suppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Lấy Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Supplier>();
            }
        }
    }
}
