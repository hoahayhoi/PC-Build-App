using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1
{
	public partial class Product_UserControl : UserControl
	{
		private int _productId; // Biến để lưu ID sản phẩm

		public Product_UserControl()
		{
			InitializeComponent();
		}

		public void SetProductInfo(Component product)
		{
			_productId = product.Id; // Lưu ID sản phẩm
			lbl_id.Text = "ID: " + product.Id.ToString();
			lblTenSp.Text = "Tên SP: " + product.Name;
			lblloaiSp.Text = "Loại SP: " + product.Category;
			lblGia.Text = "Giá SP: " + product.Price.ToString("C2");
		}

		private async void btn_xoa_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialogResult == DialogResult.Yes)
			{
				bool success = await DeleteProductFromApi(_productId); // Gọi phương thức xóa sản phẩm
				if (success)
				{
					MessageBox.Show("Sản phẩm đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Parent.Controls.Remove(this); // Xóa UserControl khỏi panel
				}
				else
				{
					MessageBox.Show("Không thể xóa sản phẩm. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private async Task<bool> DeleteProductFromApi(int productId)
		{
			using var client = new HttpClient();
			client.BaseAddress = new Uri("http://localhost:5136/api/components/"); // Địa chỉ API của bạn
			var response = await client.DeleteAsync(productId.ToString());

			if (!response.IsSuccessStatusCode)
			{
				var errorMessage = await response.Content.ReadAsStringAsync();
				MessageBox.Show($"Lỗi khi xóa sản phẩm: {response.StatusCode} - {errorMessage}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return response.IsSuccessStatusCode; // Trả về true nếu xóa thành công
		}
	}
}
