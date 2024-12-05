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
            dataGridViewUsers.DataSource = userController.GetAllUsers();
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadRoles()
        {
            var roles = userController.GetAllRoles();
            checkedListBoxRoles.Items.Clear();
            checkedListBoxRoles.Items.AddRange(roles.ToArray());
        }


        private void ClearInputs()
        {
            txtId.Clear();
            txtName.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            for (int i = 0; i < checkedListBoxRoles.Items.Count; i++)
            {
                checkedListBoxRoles.SetItemChecked(i, false);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!");
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
            if (!ValidateInputs() || string.IsNullOrEmpty(txtId.Text)) return;

            var user = new UserDto(
                txtName.Text,
                txtUsername.Text,
                txtEmail.Text,
                txtPhone.Text,
                txtPassword.Text
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
                MessageBox.Show("Có lỗi xảy ra!");
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
                    MessageBox.Show("Có lỗi xảy ra!");
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
    }
}
