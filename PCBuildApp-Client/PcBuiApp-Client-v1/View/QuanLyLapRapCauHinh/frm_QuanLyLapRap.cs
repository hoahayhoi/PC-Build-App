using PcBuiApp_Client_v1.Controller;
using PcBuiApp_Client_v1.Model;
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
    public partial class frm_QuanLyLapRap : Form
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
        private int TechId;

        public frm_QuanLyLapRap()
        {
            InitializeComponent();
            ordersController = new OrdersController();
        }

        private async void frm_QuanLyLapRap_Load(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
        }

        private async Task LoadOrdersAsync()
        {
            try
            {
                var orders = await ordersController.GetOrdersByTechIdAsync(TechId);
                DisplayOrders(orders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayOrders(List<Orders> orders)
        {
            dgv_DSLR.Rows.Clear();
            int stt = 1;
            foreach (var order in orders)
            {
                int rowIndex = dgv_DSLR.Rows.Add();
                DataGridViewRow row = dgv_DSLR.Rows[rowIndex];
                row.Cells["Column_STT"].Value = stt++;
                row.Cells["Column_OrdersId"].Value = order.Id;
                row.Cells["Column_Deadline"].Value = order.DateCompleted;
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

        private void dgv_DSLR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_DSLR.Columns["Column_ListAccountAction"].Index && e.RowIndex >= 0)
            {
                var order = (Orders)dgv_DSLR.Rows[e.RowIndex].Tag;
                frm_ChiTietDonHang f = new frm_ChiTietDonHang();
                f.OrderId = order.Id;
                f.ShowDialog();
            }
        }
    }
}
