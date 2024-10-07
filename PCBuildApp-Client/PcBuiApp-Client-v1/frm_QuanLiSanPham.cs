using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuiApp_Client_v1
{
	public partial class frm_QuanLiSanPham : Form
	{
		public frm_QuanLiSanPham()
		{
			InitializeComponent();
			LoadProducts();
		}

		private async void LoadProducts()
		{
			var products = await GetProductsFromApi();
			DisplayProducts(products);
		}

		private void DisplayProducts(List<Component> products)
		{
			panelProductShow.Controls.Clear();

			foreach (var product in products)
			{
				var productControl = new Product_UserControl();
				productControl.SetProductInfo(product);
				productControl.Dock = DockStyle.Top;
				panelProductShow.Controls.Add(productControl);
			}

			panelProductShow.AutoScroll = true;
		}

		public async Task<List<Component>> GetProductsFromApi()
		{
			using var client = new HttpClient { BaseAddress = new Uri("http://localhost:5136/api/") };
			client.Timeout = TimeSpan.FromSeconds(30);

			try
			{
				var response = await client.GetAsync("components");

				if (response.IsSuccessStatusCode)
				{
					var json = await response.Content.ReadAsStringAsync();
					return JsonConvert.DeserializeObject<List<Component>>(json);
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

			return new List<Component>();
		}
		private async void btnSearch_Click(object sender, EventArgs e)
		{
			string searchTerm = txtSearch.Text.Trim();

			if (!string.IsNullOrEmpty(searchTerm))
			{
				var allProducts = await GetProductsFromApi();
				var filteredProducts = allProducts
					.Where(product => product.Name != null && product.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
					.ToList();

				DisplayProducts(filteredProducts);
			}
			else
			{
				LoadProducts(); // Nếu không có từ khóa, load lại tất cả sản phẩm
			}
		}
	}

}