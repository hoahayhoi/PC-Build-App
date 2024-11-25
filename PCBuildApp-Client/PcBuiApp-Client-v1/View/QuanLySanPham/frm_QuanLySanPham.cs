using PcBuiApp_Client_v1.Controllers;
using PcBuiApp_Client_v1.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PcBuiApp_Client_v1.View.QuanLySanPham
{
    public partial class frm_QuanLySanPham : Form
    {
        private ProductController productController;

        public frm_QuanLySanPham()
        {
            InitializeComponent();
            this.Load += Frm_QuanLySanPham_Load;
            btn_ThemSanPham.Click += Btn_ThemSanPham_Click;
            productController = new ProductController();
        }

        private async void Frm_QuanLySanPham_Load(object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                var products = await productController.GetProductsAsync();
                DisplayProducts(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayProducts(List<Product> products)
        {
            dataGridView1.Rows.Clear();
            int stt = 1;
            foreach (var product in products)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.Cells["Column_ListAccountSTT"].Value = stt++;
                row.Cells["Column_TenSanPham"].Value = product.name;
                row.Cells["Column_GiaSanPham"].Value = product.price;
                row.Cells["Column_DanhMucSanPham"].Value = product.category;
                row.Cells["Column_SoLuongTon"].Value = product.stock;
                row.Tag = product;
                // Thêm các nút hành động (Edit, Delete)
                DataGridViewButtonCell actionCell = new DataGridViewButtonCell();
                actionCell.Value = "Hành Động";
                row.Cells["Column_HanhDongSanPham"] = actionCell;
            }
        }

        private async void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra cột "Hành Động" và dòng hợp lệ
            if (e.ColumnIndex == dataGridView1.Columns["Column_HanhDongSanPham"].Index && e.RowIndex >= 0)
            {
                var product = (Product)dataGridView1.Rows[e.RowIndex].Tag;

                // Sử dụng frm_ChooseAction để chọn hành động
                using (frm_ChooseAction chooseActionForm = new frm_ChooseAction())
                {
                    var result = chooseActionForm.ShowDialog();

                    if (chooseActionForm.SelectedAction == frm_ChooseAction.UserAction.Edit)
                    {
                        // Mở form chỉnh sửa sản phẩm
                        frm_ChinhSuaSanPham editProductForm = new frm_ChinhSuaSanPham(product);
                        editProductForm.FormClosed += async (s, args) => await LoadProductsAsync();
                        editProductForm.ShowDialog();
                    }
                    else if (chooseActionForm.SelectedAction == frm_ChooseAction.UserAction.Delete)
                    {
                        // Xác nhận xoá sản phẩm
                        var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmResult == DialogResult.Yes)
                        {
                            try
                            {
                                await productController.DeleteProductAsync(product.id);
                                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                await LoadProductsAsync();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void Btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            // Mở form thêm sản phẩm
            frm_ThemSanPham addProductForm = new frm_ThemSanPham();
            addProductForm.FormClosed += async (s, args) => await LoadProductsAsync();
            addProductForm.ShowDialog();
        }        
    }
}
