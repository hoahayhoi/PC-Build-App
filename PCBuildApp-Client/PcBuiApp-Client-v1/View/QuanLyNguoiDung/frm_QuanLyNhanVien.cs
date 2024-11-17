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
                row.Cells["Column_ListAccountName"].Value = user.name;
                row.Cells["Column_email"].Value = user.email;
                row.Cells["Column_phone"].Value = user.phone;
                row.Cells["Column_address"].Value = user.address;
                row.Tag = user;
                // Thêm các nút hành động
                DataGridViewButtonCell actionCell = new DataGridViewButtonCell();
                actionCell.Value = "Hành Động";
                row.Cells["Column_ListAccountAction"] = actionCell;
            }
        }

        private async void dataGridView_QLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_QLNV.Columns["Column_ListAccountAction"].Index && e.RowIndex >= 0)
            {
                var user = (AppUser)dataGridView_QLNV.Rows[e.RowIndex].Tag;

                // Hiển thị form chọn hành động
                frm_ChooseAction chooseActionForm = new frm_ChooseAction();
                chooseActionForm.ShowDialog();

                if (chooseActionForm.SelectedAction == frm_ChooseAction.UserAction.Edit)
                {
                    frm_EditUser editUserForm = new frm_EditUser(user);
                    editUserForm.FormClosed += async (s, args) => await LoadUsersAsync();
                    editUserForm.ShowDialog();
                }
                else if (chooseActionForm.SelectedAction == frm_ChooseAction.UserAction.Delete)
                {
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            await userController.DeleteUserAsync(user.id);
                            MessageBox.Show("Xóa người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadUsersAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }



        private void btn_ThemNguoiDung_Click(object sender, EventArgs e)
        {
            frm_AddUser addUserForm = new frm_AddUser();
            addUserForm.FormClosed += async (s, args) => await LoadUsersAsync();
            addUserForm.ShowDialog();
        }

    }
}
