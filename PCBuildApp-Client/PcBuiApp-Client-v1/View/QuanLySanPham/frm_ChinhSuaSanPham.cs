// View/QuanLySanPham/frm_ChinhSuaSanPham.cs
using PcBuiApp_Client_v1.Controllers;
using PcBuiApp_Client_v1.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PcBuiApp_Client_v1.View.QuanLySanPham
{
    public partial class frm_ChinhSuaSanPham : Form
    {
        private ProductController productController;
        private Product currentProduct;

        public frm_ChinhSuaSanPham(Product product)
        {
            InitializeComponent();
            productController = new ProductController();
            currentProduct = product;
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            txtName.Text = currentProduct.name;
            cmbCategory.SelectedItem = currentProduct.category;
            txtPrice.Text = currentProduct.price.ToString();
            txtStock.Text = currentProduct.stock.ToString();
        }

        private async void btn_Save_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Giá tiền phải là một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Số lượng tồn phải là một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật thông tin sản phẩm
            currentProduct.name = txtName.Text.Trim();
            currentProduct.category = cmbCategory.Text.Trim();
            currentProduct.price = price;
            currentProduct.stock = stock;

            try
            {
                await productController.UpdateProductAsync(currentProduct);
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
