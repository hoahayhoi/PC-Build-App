// Controllers/SupplierController.cs
using PcBuiApp_Client_v1.Helpers;
using PcBuiApp_Client_v1.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PcBuiApp_Client_v1.Model;

namespace PcBuiApp_Client_v1.Controllers
{
    public class SupplierController
    {
        // Lấy danh sách nhà cung cấp
        public async Task<List<Supplier>> GetSuppliersAsync()
        {
            string url = "api/suppliers";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(result);
                    return suppliers;
                }
                else
                {
                    throw new System.Exception("Không thể lấy danh sách nhà cung cấp.");
                }
            }
        }

        // Các phương thức CRUD tương tự như ProductController nếu cần
    }
}
