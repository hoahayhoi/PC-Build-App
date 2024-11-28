// View/QuanLyKho/frm_ThemSanPham.cs
using PcBuiApp_Client_v1.Controllers;
using PcBuiApp_Client_v1.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.View.QuanLyKho
{
    public partial class frm_ChiTietDonHang : Form
    {
        private ProductController productController;

        public frm_ChiTietDonHang()
        {
            InitializeComponent();
            productController = new ProductController();
        }

        // Sự kiện nút Lưu
        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Product newProduct = new Product
                {
                    name = txtName.Text.Trim(),
                    category = cmbCategory.SelectedItem.ToString(),
                    price = decimal.Parse(txtPrice.Text.Trim()),
                    stock = int.Parse(txtStock.Text.Trim()),
                    supplierID = string.IsNullOrEmpty(txtSupplier.Text.Trim()) ? (int?)null : int.Parse(txtSupplier.Text.Trim())
                };

                try
                {
                    await productController.AddProductAsync(newProduct);
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.Close();
        }

        // Kiểm tra dữ liệu nhập vào
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục sản phẩm.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price < 0)
            {
                MessageBox.Show("Giá tiền phải là số và lớn hơn hoặc bằng 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStock.Text.Trim(), out int stock) || stock < 0)
            {
                MessageBox.Show("Số lượng tồn phải là số và lớn hơn hoặc bằng 0.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrEmpty(txtSupplier.Text.Trim()) && (!int.TryParse(txtSupplier.Text.Trim(), out int supplierId) || supplierId <= 0))
            {
                MessageBox.Show("ID nhà cung cấp phải là số dương hoặc để trống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
