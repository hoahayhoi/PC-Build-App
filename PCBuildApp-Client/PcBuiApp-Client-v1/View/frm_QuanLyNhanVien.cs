using PcBuiApp_Client_v1.Controllers;
using PcBuiApp_Client_v1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.View
{
    public partial class frm_QuanLyNhanVien : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        private UserController userController;

        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
            userController = new UserController();


            this.Load += Frm_QuanLyNhanVien_Load;
        }

        private void btn_CloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            await LoadUsersAsync();
        }

        private async Task LoadUsersAsync()
        {
            try
            {
                var users = await userController.GetUsersAsync();
                DisplayUsers(users);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayUsers(List<AppUser> users)
        {
            dataGridView_QLNV.Rows.Clear();
            int stt = 1;
            foreach (var user in users)
            {
                int rowIndex = dataGridView_QLNV.Rows.Add();
                DataGridViewRow row = dataGridView_QLNV.Rows[rowIndex];
                row.Cells["Column_ListAccountSTT"].Value = stt++;
                row.Cells["Column_ListAccountName"].Value = user.UserName;

                // Thêm các nút hành động
                DataGridViewButtonCell actionCell = new DataGridViewButtonCell();
                actionCell.Value = "Sửa";
                row.Cells["Column_ListAccountAction"] = actionCell;
            }
        }

        private async void dataGridView_QLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_QLNV.Columns["Column_ListAccountAction"].Index && e.RowIndex >= 0)
            {
                var userName = dataGridView_QLNV.Rows[e.RowIndex].Cells["Column_ListAccountName"].Value.ToString();

                var action = dataGridView_QLNV.Columns[e.ColumnIndex].Name;

                if (action == "Edit")
                {
                    // Xử lý sửa như trên
                }
                else if (action == "Delete")
                {
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        await userController.DeleteUserAsync(userName);
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadUsersAsync();
                    }
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        // Thêm vào trong lớp frm_QuanLyNhanVien

        // Trong frm_QuanLyNhanVien.cs
        private async void btn_Sua_Click(object sender, EventArgs e)
        {
            // Lấy người dùng được chọn trong DataGridView
            if (dataGridView_QLNV.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_QLNV.SelectedRows[0];
                var userName = selectedRow.Cells["Column_ListAccountName"].Value.ToString();

                // Lấy thông tin chi tiết của người dùng
                var user = await userController.GetUserByUsernameAsync(userName);

                // Hiển thị form chỉnh sửa
                var frmEditUser = new frm_EditUser(user);
                if (frmEditUser.ShowDialog() == DialogResult.OK)
                {
                    // Tải lại danh sách người dùng
                    await LoadUsersAsync();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private async void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Lấy người dùng được chọn trong DataGridView
            if (dataGridView_QLNV.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_QLNV.SelectedRows[0];
                var userName = selectedRow.Cells["Column_ListAccountName"].Value.ToString();

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    await userController.DeleteUserAsync(userName);
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadUsersAsync();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
