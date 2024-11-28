using Microsoft.VisualBasic.ApplicationServices;
using PcBuiApp_Client_v1.Controller;
using PcBuiApp_Client_v1.Controllers;
using PcBuiApp_Client_v1.Models;
using PcBuiApp_Client_v1.View.QuanLyDonHang;
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
    public partial class frm_QuanLyDonHang : Form
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
        private OrdersController ordersController;
        private int order_selected;

        public frm_QuanLyDonHang()
        {
            InitializeComponent();
            ordersController = new OrdersController();
        }

        private async void frm_QuanLyDonHang_Load(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
        }

        private async Task LoadOrdersAsync()
        {
            try
            {
                var users = await ordersController.GetAllOrdersAsync();
                DisplayOrders(users);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayOrders(List<Orders> orders)
        {
            dgv_DSDonHang.Rows.Clear();
            int stt = 1;
            foreach (var order in orders)
            {
                int rowIndex = dgv_DSDonHang.Rows.Add();
                DataGridViewRow row = dgv_DSDonHang.Rows[rowIndex];
                row.Cells["Column_STT"].Value = stt++;
                row.Cells["Column_OrdersId"].Value = order.Id;
                row.Cells["Column_Date"].Value = order.CreatedOn;
                row.Cells["Column_TotalPrice"].Value = order.TotalPrice;
                row.Cells["Column_Status"].Value = order.Status;
                row.Tag = order;
                // Thêm các nút hành động
                DataGridViewButtonCell actionCell = new DataGridViewButtonCell();
                actionCell.Value = "Hành Động";
                row.Cells["Column_ListAccountAction"] = actionCell;
            }
        }

        private void btn_CloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_DSDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_DSDonHang.Columns["Column_ListAccountAction"].Index && e.RowIndex >= 0)
            {
                order_selected = e.RowIndex;
                var cell = dgv_DSDonHang.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                Point point = new Point(cell.X, cell.Y + cell.Height);

                contextMenuStrip1.Show(dgv_DSDonHang, point);
            }
        }

        private async void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (order_selected >= 0) 
            {
                var order = (Orders)dgv_DSDonHang.Rows[order_selected].Tag;

                switch (e.ClickedItem.Text)
                {
                    case "Chi Tiết":
                        {
                            frm_ChiTietDonHang f = new frm_ChiTietDonHang();
                            f.OrderId = order.Id;
                            f.ShowDialog();
                            break;
                        }
                    case "Xóa":
                        {
                            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                try
                                {
                                    await ordersController.DeleteOrderAsync(order.Id);
                                    MessageBox.Show("Xóa đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    await LoadOrdersAsync();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lỗi khi xóa đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            break;
                        }
                }
            }
        }
    }
}
