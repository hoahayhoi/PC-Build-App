using App.Controller;
using App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace App.View.QuanLyTaiKhoan
{
    public partial class QuanLyTaiKhoan : Form
    {
        private UserController userController;

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            userController = new UserController();
            LoadUsers();
            LoadRoles();
        }

        private void LoadUsers()
        {
            try
            {
                var dt = userController.GetAllUsers();
                dataGridViewUsers.DataSource = dt;

                // Format lại tên cột
                if (dataGridViewUsers.Columns["Id"] != null) dataGridViewUsers.Columns["Id"].HeaderText = "Mã";
                if (dataGridViewUsers.Columns["Name"] != null) dataGridViewUsers.Columns["Name"].HeaderText = "Họ Tên";
                if (dataGridViewUsers.Columns["UserName"] != null) dataGridViewUsers.Columns["UserName"].HeaderText = "Tên đăng nhập";
                if (dataGridViewUsers.Columns["Email"] != null) dataGridViewUsers.Columns["Email"].HeaderText = "Email";
                if (dataGridViewUsers.Columns["Phone"] != null) dataGridViewUsers.Columns["Phone"].HeaderText = "Điện thoại";
                if (dataGridViewUsers.Columns["Roles"] != null) dataGridViewUsers.Columns["Roles"].HeaderText = "Vai trò";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách: {ex.Message}");
            }
        }

        private void ClearInputs()
        {
            txtId.Clear();
            txtName.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();

            // Bỏ chọn tất cả roles
            for (int i = 0; i < checkedListBoxRoles.Items.Count; i++)
            {
                checkedListBoxRoles.SetItemChecked(i, false);
            }
        }

        private void LoadRoles()
        {
            var roles = userController.GetAllRoles();
            checkedListBoxRoles.Items.Clear();
            checkedListBoxRoles.Items.AddRange(roles.ToArray());
        }

        private bool ValidateInputs(bool isUpdate = false)
        {
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) ||
                (!isUpdate && string.IsNullOrEmpty(txtPassword.Text))) // Chỉ kiểm tra password khi thêm mới
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc (Tên, Tên đăng nhập" +
                    (!isUpdate ? ", Mật khẩu" : "") + ")!");
                return false;
            }

            if (checkedListBoxRoles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vai trò!");
                return false;
            }
            return true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var user = new UserDto(
                txtName.Text,
                txtUsername.Text,
                txtEmail.Text,
                txtPhone.Text,
                txtPassword.Text
            );

            var selectedRoles = checkedListBoxRoles.CheckedItems.Cast<string>().ToList();

            if (userController.AddUser(user, selectedRoles))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadUsers();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs(true)) return;
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật!");
                    return;
                }

                var user = new UserDto(
                    txtName.Text.Trim(),
                    txtUsername.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPhone.Text.Trim(),
                    string.IsNullOrEmpty(txtPassword.Text) ? null : txtPassword.Text.Trim() // Chỉ cập nhật password nếu có nhập
                );

                var selectedRoles = checkedListBoxRoles.CheckedItems.Cast<string>().ToList();

                if (userController.UpdateUser(int.Parse(txtId.Text), user, selectedRoles))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadUsers();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật tài khoản! Vui lòng kiểm tra lại thông tin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            ClearInputs();
            LoadUsers();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (userController.DeleteUser(int.Parse(txtId.Text)))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadUsers();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!!");
                }
            }
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var row = dataGridViewUsers.SelectedRows[0];

                // Hiển thị thông tin lên các textbox
                txtId.Text = row.Cells["Id"].Value?.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtUsername.Text = row.Cells["UserName"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();

                // Lấy danh sách roles từ cột Roles và check vào checkedListBox
                string roles = row.Cells["Roles"].Value?.ToString();
                if (!string.IsNullOrEmpty(roles))
                {
                    // Bỏ chọn tất cả
                    for (int i = 0; i < checkedListBoxRoles.Items.Count; i++)
                    {
                        checkedListBoxRoles.SetItemChecked(i, false);
                    }

                    // Check các role được chọn
                    var roleList = roles.Split(',').Select(r => r.Trim()).ToList();
                    for (int i = 0; i < checkedListBoxRoles.Items.Count; i++)
                    {
                        if (roleList.Contains(checkedListBoxRoles.Items[i].ToString()))
                        {
                            checkedListBoxRoles.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void checkedListBoxRoles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Bỏ check tất cả các item khác
            for (int i = 0; i < checkedListBoxRoles.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkedListBoxRoles.SetItemChecked(i, false);
                }
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            FilterInventory(searchTerm);
        }

        private void FilterInventory(string searchTerm)
        {
            if (dataGridViewUsers.DataSource != null)
            {
                DataTable dt = (DataTable)dataGridViewUsers.DataSource;

                if (string.IsNullOrEmpty(searchTerm))
                {
                    dataGridViewUsers.DataSource = dt;
                    LoadUsers();
                }
                else
                {
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = string.Format("Name LIKE '%{0}%'", searchTerm);

                    dataGridViewUsers.DataSource = dv.ToTable();
                }
            }
        }
    }
}
