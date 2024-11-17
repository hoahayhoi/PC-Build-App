using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using PcBuiApp_Client_v1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.View
{
    public partial class frm_DSLapRap : Form
    {
        public frm_DSLapRap()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.Blue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            load_PhanLoai();
            load_DSDHCLR("Tất cả");
        }

        private async void load_DSDHCLR(string loai)
        {
            mLV_DSDHCLR.Columns.Add("STT", 80);
            mLV_DSDHCLR.Columns.Add("ID", 150);
            mLV_DSDHCLR.Columns.Add("Tên Khách Hàng", 150);
            mLV_DSDHCLR.Columns.Add("Ngày Yêu Cầu", 150);
            mLV_DSDHCLR.Columns.Add("Hạn Hoàn Thành", 150);
            mLV_DSDHCLR.Columns.Add("Trạng Thái", 150);

            List<Order> orders = new List<Order>();
            switch (loai)
            {
                case "Tất cả":
                    {
                        orders = await GetOrdersByTechIdFromApi();
                        break;
                    }
                case "Chờ lắp ráp":
                    {
                        orders = await GetOrdersByTechIdFromApi();
                        break;
                    }
                case "Đang lắp ráp":
                    {
                        orders = await GetOrdersByTechIdFromApi();
                        break;
                    }
                case "Hoàn thành":
                    {
                        orders = await GetOrdersByTechIdFromApi();
                        break;
                    }
            };
            int i = 1;
            foreach (var order in orders)
            {
                ListViewItem item = new ListViewItem(i.ToString());

                item.SubItems.Add(order.id);
                item.SubItems.Add(order.customerID);
                item.SubItems.Add(order.createdOn.ToString());
                item.SubItems.Add(order.dateCompleted.ToString());
                item.SubItems.Add(order.status);

                mLV_DSDHCLR.Items.Add(item);
                i++;
            }
        }

        public async Task<List<Order>> GetOrdersByTechIdFromApi()
        {
            using var client = new HttpClient { BaseAddress = new Uri("http://localhost:5136/api/") };
            client.Timeout = TimeSpan.FromSeconds(30);

            try
            {
                var response = await client.GetAsync("orders/GetOrdersByTechId/bd5e7356-476a-4907-89c1-267619afb888");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Order>>(json);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            return new List<Order>();
        }

        private void load_PhanLoai()
        {
            var ploai = new List<string> { "Tất cả", "Chờ lắp ráp", "Đang lắp ráp", "Hoàn thành" };
            mCBB_PhanLoai.DataSource = ploai;
        }

        private void mCBB_PhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            mLV_DSDHCLR.Items.Clear();
            load_DSDHCLR(mCBB_PhanLoai.SelectedItem.ToString());
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex == 1)
            {
                //frm_QuanLiSanPham frm = new frm_QuanLiSanPham();
                //frm.Show();
                //this.Hide();
            }
            if (materialTabControl1.SelectedIndex == 5)
            {
                frm_DangNhap frm = new frm_DangNhap();
                frm.Show();
                this.Hide();
            }
        }
    }
}
