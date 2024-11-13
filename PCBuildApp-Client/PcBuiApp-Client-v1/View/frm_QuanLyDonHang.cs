using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcBuiApp_Client_v1.Models;

namespace PcBuiApp_Client_v1.View
{
	public partial class frm_QuanLyDonHang : Form
	{
		private readonly HttpClient _httpClient;

		public frm_QuanLyDonHang()
		{
			InitializeComponent();
			_httpClient = new HttpClient();
			LoadOrderData().ConfigureAwait(false);
		}

		private async Task LoadOrderData()
		{
			try
			{
				var response = await _httpClient.GetAsync("http://localhost:5136/api/orders");
				response.EnsureSuccessStatusCode();
				var json = await response.Content.ReadAsStringAsync();
				var options = new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = true,
					DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
				};
				var orders = JsonSerializer.Deserialize<List<Orders>>(json, options);

				if (orders != null && orders.Count > 0)
				{
					dataGridView1.AutoGenerateColumns = true;
					dataGridView1.DataSource = orders;
					dataGridView1.Refresh();
				}
				else
				{
					MessageBox.Show("Danh sách đơn hàng rỗng hoặc không có dữ liệu.", "Thông báo");
				}
			}
			catch (HttpRequestException httpEx)
			{
				MessageBox.Show($"Không thể kết nối đến server: {httpEx.Message}", "Lỗi kết nối");
			}
			catch (JsonException jsonEx)
			{
				MessageBox.Show($"Lỗi khi chuyển đổi JSON: {jsonEx.Message}", "Lỗi JSON");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi khác");
			}
		}

		




		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Xử lý các sự kiện khi click vào DataGridView
		}
	}
}
