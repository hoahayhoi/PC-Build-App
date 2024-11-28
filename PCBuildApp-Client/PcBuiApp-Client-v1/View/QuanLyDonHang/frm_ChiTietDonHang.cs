using Microsoft.VisualBasic.ApplicationServices;
using PcBuiApp_Client_v1.Controller;
using PcBuiApp_Client_v1.Controllers;
using PcBuiApp_Client_v1.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.View.QuanLyDonHang
{
    public partial class frm_ChiTietDonHang : Form
    {
        private OrdersController ordersController;
        private UserController userController;
        private ProductController productController;
        public int OrderId { get; set; }

        public frm_ChiTietDonHang()
        {
            InitializeComponent();
            ordersController = new OrdersController();
            userController = new UserController();
            productController = new ProductController();

            txtMaDH.Enabled = false;
            dtpNgayTao.Enabled = false;
            dtpNgayHT.Enabled = false;
            txtTongTien.Enabled = false;
            txtKH.Enabled = false;
            cbNVBH.Enabled = false;
            cbKTV.Enabled = false;
            txtStatus.Enabled = false;
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
        }

        // Sự kiện nút Lưu
        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Orders newOrder = new Orders
                {
                    //DateCompleted = DateTime.Parse(dtpNgayHT.ToString()),
                    Status = txtStatus.Text,
                    TotalPrice = decimal.Parse(txtTongTien.Text)
                };

                try
                {
                    await ordersController.UpdateOrderInfoAsync(newOrder);
                    MessageBox.Show("Cập nhật đơn hàng thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sự kiện nút Hủy
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txtTongTien.Enabled = false;
            dtpNgayHT.Enabled = false;
            txtStatus.Enabled = false;
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_Sua.Enabled = true;
            LoadOrder();
        }

        // Kiểm tra dữ liệu nhập vào
        private bool ValidateInput()
        {
            if (txtStatus.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Vui lòng cập nhật trạng thái đơn hàng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void frm_ChiTietDonHang_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private async Task LoadOrder()
        {
            try
            {
                var order = await ordersController.GetOrderByIdAsync(OrderId);
                DisplayOrder(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DisplayOrder(Orders order)
        {
            txtMaDH.Text = order.Id.ToString();
            dtpNgayTao.Text = order.CreatedOn.ToString();
            dtpNgayHT.Text = order.DateCompleted.ToString();
            txtTongTien.Text = order.TotalPrice.ToString();

            //var customer = await userController.GetUserByIdAsync(order.CustomerID);
            //txtKH.Text = customer.name;

            //cbNVBH.SelectedItem = order.SalesStaffID;
            //cbKTV.SelectedItem = order.TechnicianID;
            txtStatus.Text = order.Status;

            //dgv_DSSP.Rows.Clear();
            //int stt = 1;
            //foreach (var detail in order.Details)
            //{
            //    int rowIndex = dgv_DSSP.Rows.Add();
            //    DataGridViewRow row = dgv_DSSP.Rows[rowIndex];
            //    row.Cells["Column_STT"].Value = stt++;

            //    var product = await productController.GetProductByIdAsync(detail.ProductId);
            //    row.Cells["Column_Product"].Value = product.name;

            //    row.Cells["Column_Quanity"].Value = detail.Quantity;
            //    row.Cells["Column_TotalPrice"].Value = detail.TotalPrice;
            //    row.Tag = detail;
            //}
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txtTongTien.Enabled = true;
            dtpNgayHT.Enabled = true;
            txtStatus.Enabled = true;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
            btn_Sua.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
