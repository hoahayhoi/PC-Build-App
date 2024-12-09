using System;
using System.Data;
using System.Windows.Forms;
using App.Controller;

namespace App.View.QuanLyKho
{
    public partial class QuanLyKho : Form
    {
        private InventoryController _inventoryController;

        public QuanLyKho()
        {
            InitializeComponent();
            _inventoryController = new InventoryController();
        }

        // Tải danh sách tồn kho
        private void btnLoadInventory_Click(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void LoadInventory()
        {
            DataTable dt = _inventoryController.GetInventory();
            dgvInventory.DataSource = dt;
        }

        // Thực hiện nhập kho
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (cbComponent.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn linh kiện!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!");
                return;
            }

            int componentId = (int)cbComponent.SelectedValue;
            string note = txtNote.Text;
            int importedBy = 1; // Giả sử người nhập kho là UserID = 1

            bool result = _inventoryController.ImportInventory(componentId, quantity, 1, 100, note, importedBy);
            LoadInventory();
            MessageBox.Show(result ? "Thêm thành công!" : "Vui lòng kiểm tra lại!");
        }

        // Thực hiện xuất kho
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (cbComponent.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn linh kiện!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!");
                return;
            }

            int componentId = (int)cbComponent.SelectedValue;
            string note = txtNote.Text;
            int exportedBy = 1;

            bool result = _inventoryController.ExportInventory(componentId, quantity, null, note, exportedBy);
            MessageBox.Show(result ? "Xuất kho thành công!" : "Vui lòng kiểm tra lại!");
            LoadInventory();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            LoadComponents();
            LoadInventory();

        }

        private void groupBoxFilters_Enter(object sender, EventArgs e)
        {

        }

        private void LoadComponents()
        {
            // Lấy danh sách components từ controller
            DataTable components = _inventoryController.GetComponents();

            // Cập nhật ComboBox
            cbComponent.DataSource = components;
            cbComponent.DisplayMember = "Name";  // Tên hiển thị trong ComboBox
            cbComponent.ValueMember = "Id";     // Giá trị thực tế được gửi khi chọn
        }

        private void textBox_SearchKho_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox_SearchKho.Text.ToLower();
            FilterInventory(searchTerm);
        }

        private void FilterInventory(string searchTerm)
        {
            if (dgvInventory.DataSource != null)
            {
                DataTable dt = (DataTable)dgvInventory.DataSource;

                if (string.IsNullOrEmpty(searchTerm))
                {
                    dgvInventory.DataSource = dt;
                    LoadInventory();
                }
                else
                {
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = string.Format("Name LIKE '%{0}%'", searchTerm);

                    dgvInventory.DataSource = dv.ToTable();
                }
            }
        }

        private void dgvInventory_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin của dòng được chọn
                DataGridViewRow selectedRow = dgvInventory.Rows[e.RowIndex];

                txtQuantity.Text = selectedRow.Cells["CurrentStock"].Value.ToString(); 
                txtNote.Text = ""; 

                cbComponent.SelectedValue = selectedRow.Cells["Id"].Value;

            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
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
