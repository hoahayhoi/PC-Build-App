// Controllers/ProductController.cs
using PcBuiApp_Client_v1.Helpers;
using PcBuiApp_Client_v1.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PcBuiApp_Client_v1.Controllers
{
    public class ProductController
    {
        // Lấy danh sách sản phẩm
        public async Task<List<Product>> GetProductsAsync()
        {
            string url = "api/components";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<List<Product>>(result);
                    return products;
                }
                else
                {
                    throw new System.Exception("Không thể lấy danh sách sản phẩm.");
                }
            }
        }

        // Lấy sản phẩm theo ID
        public async Task<Product> GetProductByIdAsync(int id)
        {
            string url = $"api/components/{id}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var product = JsonConvert.DeserializeObject<Product>(result);
                    return product;
                }
                else
                {
                    throw new System.Exception("Không thể lấy thông tin sản phẩm.");
                }
            }
        }

        // Thêm sản phẩm mới
        public async Task AddProductAsync(Product product)
        {
            string url = "api/components/create";

            var productDto = new
            {
                name = product.name,
                category = product.category,
                price = product.price,
                stock = product.stock
            };

            var json = JsonConvert.SerializeObject(productDto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(url, data))
            {
                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new System.Exception("Không thể thêm sản phẩm: " + error);
                }
            }
        }

        // Sửa sản phẩm
        public async Task UpdateProductAsync(Product product)
        {
            string url = $"api/components/edit/{product.id}";

            var productDto = new
            {
                name = product.name,
                category = product.category,
                price = product.price,
                stock = product.stock
            };

            var json = JsonConvert.SerializeObject(productDto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync(url, data))
            {
                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new System.Exception("Không thể cập nhật sản phẩm: " + error);
                }
            }
        }

        // Xóa sản phẩm
        public async Task<bool> DeleteProductAsync(int id)
        {
            string url = $"api/components/delete/{id}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new System.Exception("Không thể xóa sản phẩm: " + error);
                }
            }
        }

        // Lấy sản phẩm theo truy vấn (tìm kiếm)
        public async Task<List<Product>> GetProductsByQueryAsync(string query)
        {
            string url = $"api/components/GetComponentsByQuery?name={Uri.EscapeDataString(query)}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<List<Product>>(result);
                    return products;
                }
                else
                {
                    throw new System.Exception("Không thể tìm kiếm sản phẩm.");
                }
            }
        }
    }
}
