// View/frm_QuanLyKho.cs
using PcBuiApp_Client_v1.Controllers;
using PcBuiApp_Client_v1.Models;
using PcBuiApp_Client_v1.View.QuanLyKho;
using PcBuiApp_Client_v1.View.QuanLySanPham;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.View
{
    public partial class frm_QuanLyKho : Form
    {
        private ProductController productController;
        private List<Product> products;

        public frm_QuanLyKho()
        {
            InitializeComponent();
            productController = new ProductController();
            Load += frm_QuanLyKho_Load;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private async void frm_QuanLyKho_Load(object sender, EventArgs e)
        {
            await LoadProducts();
        }

        // Tải danh sách sản phẩm từ API và hiển thị vào DataGridView
        private async System.Threading.Tasks.Task LoadProducts()
        {
            try
            {
                products = await productController.GetProductsAsync();
                BindDataToGridView(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Liên kết dữ liệu với DataGridView
        private void BindDataToGridView(List<Product> products)
        {
            dataGridViewProducts.Rows.Clear();
            int stt = 1;
            foreach (var product in products)
            {
                dataGridViewProducts.Rows.Add(stt++, product.name, product.category, product.price.ToString("C0"), product.stock);
            }
        }

        // Sự kiện đóng form
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện tìm kiếm sản phẩm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        // Thực hiện tìm kiếm sản phẩm
        private void PerformSearch()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var filteredProducts = products.Where(p => p.name.ToLower().Contains(keyword) || p.category.ToLower().Contains(keyword)).ToList();
            BindDataToGridView(filteredProducts);
        }

        // Sự kiện thêm sản phẩm
        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_ThemSanPham themSanPhamForm = new frm_ThemSanPham();
            themSanPhamForm.FormClosed += ThemSanPhamForm_FormClosed;
            themSanPhamForm.ShowDialog();
        }

        private async void ThemSanPhamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await LoadProducts();
        }

        // Sự kiện khi nhấp vào nút Xóa trong DataGridView
        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var columnName = dataGridViewProducts.Columns[e.ColumnIndex].Name;

                if (columnName == "Column_Delete")
                {
                    // Lấy sản phẩm được chọn
                    var selectedProduct = products[e.RowIndex];
                    DeleteProduct(selectedProduct.id);
                }
            }
        }

        // Xóa sản phẩm
        private async void DeleteProduct(int productId)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    await productController.DeleteProductAsync(productId);
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
