using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1.View.DeXuatCauHinh
{
	public partial class frm_dexuatcauhinh : Form
	{
		private static readonly HttpClient client = new HttpClient();

		public frm_dexuatcauhinh()
		{
			InitializeComponent();
		}

		private void frm_dexuatcauhinh_Load(object sender, EventArgs e)
		{
			// Thực hiện bất kỳ thao tác nào khi form load nếu cần
		}

		// Phương thức gọi API và lấy cấu hình máy tính dựa trên giá tiền và mục đích sử dụng
		private async Task<ResponseData> SendPredictionRequestAsync(double total_price, int purpose)
		{
			try
			{
				// Dữ liệu JSON cần gửi đi
				var requestData = new
				{
					total_price = total_price,
					purpose = purpose
				};

				// Chuyển đổi dữ liệu thành chuỗi JSON
				var jsonContent = JsonConvert.SerializeObject(requestData);

				var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

				// Gửi yêu cầu POST tới API
				var response = await client.PostAsync("http://127.0.0.1:5000/predict", content);

				// Kiểm tra phản hồi từ API
				if (response.IsSuccessStatusCode)
				{
					var responseString = await response.Content.ReadAsStringAsync();
					// Chuyển đổi kết quả JSON thành đối tượng ResponseData
					var result = JsonConvert.DeserializeObject<ResponseData>(responseString);
					// Trả về đối tượng kết quả
					return result;

				}
				else
				{
					MessageBox.Show("Lỗi khi gửi yêu cầu: " + response.ReasonPhrase);
					return null;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
				return null;
			}
		}

		// Phương thức hiển thị cấu hình máy tính lên UI
		private async Task ShowPCConfigs(double total_price, int purpose)
		{
			try
			{
				// Gọi API để lấy cấu hình máy tính
				var pcConfig = await SendPredictionRequestAsync(total_price, purpose);

				// Hiển thị cấu hình nếu có
				if (pcConfig != null && !string.IsNullOrEmpty(pcConfig.SuggestedConfiguration) && pcConfig.TotalPrice != 0)
				{
					paneldexuat1.AutoScroll = true;
					paneldexuat1.Controls.Clear();

					// Biến lưu vị trí Y để đặt các UserControl đúng vị trí trong panel
					int yPosition = 10;

					// Tạo UserControl để hiển thị cấu hình PC
					var userControl = new UserControlCustom.Usercontroldexuat(
						pcConfig.SuggestedConfiguration,  // Truyền cấu hình đề xuất
						pcConfig.TotalPrice               // Truyền giá tiền
					);

					userControl.Width = paneldexuat1.ClientSize.Width - 20;  // Đảm bảo chiều rộng đúng
					userControl.Height = 200;  // Chiều cao của UserControl
					userControl.Location = new System.Drawing.Point(10, yPosition);  // Đặt vị trí Y

					paneldexuat1.Controls.Add(userControl);  // Thêm vào panel
				}
				else
				{
					// Nếu không có cấu hình hợp lệ, hiển thị thông báo
					MessageBox.Show("Không có cấu hình đề xuất!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}



		// Hàm lấy giá trị mục đích từ ComboBox
		private int GetPurposeFromComboBox()
		{
			// Kiểm tra giá trị đã chọn trong ComboBox và trả về mục đích tương ứng
			if (cmbmucdich.GetItemText(cmbmucdich.SelectedItem).Equals("Văn Phòng"))
			{
				return 2;  // Mục đích: Văn Phòng
			}
			else if (cmbmucdich.GetItemText(cmbmucdich.SelectedItem).Equals("Chơi Game"))
			{
				return 0;  // Mục đích: Chơi Game
			}
			else
			{
				return 1;  // Mặc định: Mục đích khác
			}
		}

		// Sự kiện click nút "Đề xuất"
		private async void btn_dexuat_Click(object sender, EventArgs e)
		{
			try
			{
				// Lấy giá trị từ các điều khiển (textbox và combobox)
				double total_price = double.Parse(txtGiatien.Text);  // Lấy giá trị giá tiền từ txtGiatien
				int purpose = GetPurposeFromComboBox();  // Lấy mục đích từ ComboBox cmbmucdich

				// Gọi hàm ShowPCConfigs để gửi yêu cầu và hiển thị cấu hình đề xuất
				await ShowPCConfigs(total_price, purpose);
			}
			catch (Exception ex)
			{
				// Hiển thị thông báo lỗi nếu có vấn đề trong quá trình xử lý
				MessageBox.Show("Lỗi: " + ex.Message);
				Console.WriteLine(ex.StackTrace);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}

	// Lớp đại diện cho dữ liệu phản hồi từ API
	public class ResponseData
	{
		public int Purpose { get; set; }

		[JsonProperty("suggested_configuration")]
		public string SuggestedConfiguration { get; set; } // Loại bỏ nullable cho SuggestedConfiguration
		[JsonProperty("total_price")]
		public double TotalPrice { get; set; }
	}
}
