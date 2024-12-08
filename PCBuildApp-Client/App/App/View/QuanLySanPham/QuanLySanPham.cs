using App.Controller;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.View.QuanLySanPham
{
    public partial class QuanLySanPham : Form
    {
        private ComponentController componentController;
        private CategoryController categoryController;

        public QuanLySanPham()
        {
            InitializeComponent();
            componentController = new ComponentController();
            categoryController = new CategoryController();
            LoadCategories(); // Tải danh mục trước khi thiết lập DataGridView và LoadComponents
            SetupDataGridView();
            LoadComponents();
        }

        void SetupDataGridView()
        {
            dataGridView_Components.AutoGenerateColumns = false;
            dataGridView_Components.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Components.MultiSelect = false;
            dataGridView_Components.ReadOnly = true;
            dataGridView_Components.RowTemplate.Height = 80;

            // Cấu hình các cột
            dataGridView_Components.Columns.Clear();

            dataGridView_Components.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Mã SP",
                DataPropertyName = "Id",
                Width = 70
            });

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                Name = "ProductImage",
                HeaderText = "Hình ảnh",
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                DataPropertyName = "ProductImage",
                Width = 80,
            };
            dataGridView_Components.Columns.Add(imageColumn);

            dataGridView_Components.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "Name",
                Width = 200
            });

            dataGridView_Components.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ImageFileName",
                HeaderText = "Image File Name",
                DataPropertyName = "ImageFileName",
                Visible = false
            });

            dataGridView_Components.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Category",
                HeaderText = "Danh mục",
                DataPropertyName = "Category",
                Width = 100
            });

            dataGridView_Components.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Giá",
                DataPropertyName = "Price",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dataGridView_Components.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Stock",
                HeaderText = "Tồn kho",
                DataPropertyName = "Stock",
                Width = 80
            });

            // Thêm cột CategoryID ẩn
            dataGridView_Components.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryID",
                HeaderText = "CategoryID",
                DataPropertyName = "CategoryID",
                Visible = false
            });
        }

        private void LoadComponents()
        {
            DataTable dt = componentController.GetAllComponents();
            DataTable newDt = new DataTable();

            newDt.Columns.Add("Id", typeof(int));
            newDt.Columns.Add("ProductImage", typeof(Image));
            newDt.Columns.Add("Name", typeof(string));
            newDt.Columns.Add("Category", typeof(string));
            newDt.Columns.Add("Price", typeof(decimal));
            newDt.Columns.Add("Stock", typeof(int));
            newDt.Columns.Add("CategoryID", typeof(int));
            newDt.Columns.Add("ImageFileName", typeof(string)); // Thêm cột ImageFileName

            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = newDt.NewRow();
                newRow["Id"] = row["Id"];
                newRow["Name"] = row["Name"];
                newRow["Category"] = row["CategoryName"];
                newRow["Price"] = row["Price"];
                newRow["Stock"] = row["Stock"];
                newRow["CategoryID"] = row["CategoryID"];

                string imageName = row["Image"].ToString();
                newRow["ImageFileName"] = imageName; // Lưu tên tệp ảnh

                string imagePath = GetFullImagePath(imageName);

                if (File.Exists(imagePath))
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        newRow["ProductImage"] = Image.FromStream(stream);
                    }
                }
                else
                {
                    newRow["ProductImage"] = null;
                }

                newDt.Rows.Add(newRow);
            }

            dataGridView_Components.DataSource = newDt;
        }


        private void LoadCategories()
        {
            DataTable dt = categoryController.GetAllCategories();
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";
            cboCategory.SelectedIndex = -1; // Không chọn mặc định
        }

        private void ClearInputs()
        {
            txt_IdProduct.Clear();
            txt_NameProduct.Clear();
            txt_Price.Clear();
            textBoxAddress.Clear(); // Stock
            cboCategory.SelectedIndex = -1;
            textBox_ImagePath.Clear(); // Image
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txt_NameProduct.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                return false;
            }

            if (!decimal.TryParse(txt_Price.Text, out _))
            {
                MessageBox.Show("Giá không hợp lệ");
                return false;
            }

            if (!int.TryParse(textBoxAddress.Text, out _))
            {
                MessageBox.Show("Số lượng tồn không hợp lệ");
                return false;
            }

            if (cboCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục");
                return false;
            }

            return true;
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string name = txt_NameProduct.Text;
            int categoryId = (int)cboCategory.SelectedValue; // Sử dụng CategoryID
            decimal price = decimal.Parse(txt_Price.Text);
            int stock = int.Parse(textBoxAddress.Text);
            string image = textBox_ImagePath.Text;

            if (componentController.AddComponent(name, categoryId, price, stock, image, null))
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadComponents();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại!");
            }
        }

        private void btn_SuaSanPham_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs() || string.IsNullOrEmpty(txt_IdProduct.Text)) return;

            int id = int.Parse(txt_IdProduct.Text);
            string name = txt_NameProduct.Text;
            int categoryId = (int)cboCategory.SelectedValue; // Sử dụng CategoryID
            decimal price = decimal.Parse(txt_Price.Text);
            int stock = int.Parse(textBoxAddress.Text);
            string image = textBox_ImagePath.Text;

            if (componentController.UpdateComponent(id, name, categoryId, price, stock, image, null))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadComponents();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btn_XoaSanPham_Click(object sender, EventArgs e)
        {
            if (dataGridView_Components.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView_Components.SelectedRows[0].Cells["Id"].Value);
                if (componentController.DeleteComponent(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadComponents();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {
            ClearInputs();
            //LoadComponents();
        }

        private void CreateImageFolderIfNotExist()
        {
            string imagePath = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(imagePath))
            {
                Directory.CreateDirectory(imagePath);
            }
        }


        private void btn_ThemImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Chọn ảnh sản phẩm";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Tạo thư mục Images nếu chưa có
                        CreateImageFolderIfNotExist();

                        // Lấy tên file và đường dẫn đích
                        string fileName = Path.GetFileName(openFileDialog.FileName);
                        string uniqueFileName = $"{DateTime.Now:yyyyMMddHHmmss}_{fileName}";
                        string destinationPath = Path.Combine(Application.StartupPath, "Images", uniqueFileName);

                        // Copy file ảnh vào thư mục Images
                        File.Copy(openFileDialog.FileName, destinationPath, true);

                        // Hiển thị tên file trong textbox
                        textBox_ImagePath.Text = uniqueFileName;

                        MessageBox.Show("Tải ảnh lên thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}");
                    }
                }
            }
        }

        // Hàm lấy đường dẫn đầy đủ của ảnh
        private string GetFullImagePath(string imageName)
        {
            if (string.IsNullOrEmpty(imageName)) return "";
            return Path.Combine(Application.StartupPath, "Images", imageName);
        }


        // Cập nhật hiển thị ảnh khi chọn row trong DataGridView
        private void dataGridView_Components_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Components.SelectedRows.Count > 0)
            {
                var row = dataGridView_Components.SelectedRows[0];
                txt_IdProduct.Text = row.Cells["Id"].Value.ToString();
                txt_NameProduct.Text = row.Cells["Name"].Value.ToString();
                txt_Price.Text = row.Cells["Price"].Value.ToString();
                textBoxAddress.Text = row.Cells["Stock"].Value.ToString();
                cboCategory.SelectedValue = row.Cells["CategoryID"].Value;
                textBox_ImagePath.Text = row.Cells["ImageFileName"].Value?.ToString();
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Components_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
