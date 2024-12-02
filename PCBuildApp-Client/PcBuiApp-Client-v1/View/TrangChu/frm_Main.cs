using Newtonsoft.Json;
using PcBuiApp_Client_v1.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.View.TrangChu
{
	public partial class frm_Main : Form
	{
		private static readonly HttpClient client = new HttpClient();

		public frm_Main()
		{
			InitializeComponent();
			ShowPCConfigs();             // Hiển thị các cấu hình PC
		}

		private async Task<List<PCConfig>> GetPCConfigsFromApiAsync()
		{
			try
			{
				string apiUrl = "http://localhost:5136/api/configurations";
				var response = await client.GetStringAsync(apiUrl);
				return JsonConvert.DeserializeObject<List<PCConfig>>(response);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi lấy dữ liệu từ API: {ex.Message}");
				return new List<PCConfig>();
			}
		}

		private async void ShowPCConfigs()
		{
			panelMain.AutoScroll = true;
			var pcConfigs = await GetPCConfigsFromApiAsync();
			int yPosition = 10;

			panelMain.Controls.Clear();  // Xóa hết các control cũ trong panel

			foreach (var pcConfig in pcConfigs)
			{
				// Tạo PCconfig mới và thêm vào panel
				var pcControl = new UserControlCustom.PCconfig(
					pcConfig.Id,
					pcConfig.SuggestedComponents
				);
				pcControl.Width = panelMain.ClientSize.Width - 20;  // Đảm bảo chiều rộng đúng
				pcControl.Height = 100;  // Cài đặt chiều cao của mỗi control
				pcControl.Location = new System.Drawing.Point(10, yPosition);

				// Thêm UserControl vào panelMain
				panelMain.Controls.Add(pcControl);

				// Cập nhật vị trí y cho control tiếp theo (thêm khoảng cách 10px)
				yPosition += pcControl.Height + 10;
			}

			// Cập nhật chiều cao của panelMain để có thể cuộn
			panelMain.Height = yPosition + 10;  // Đảm bảo chiều cao panel đủ lớn
		}

		private void label1_Click(object sender, EventArgs e)
		{
			// Xử lý sự kiện nếu cần
		}
	}
}
