// Controllers/ReportController.cs
using PcBuiApp_Client_v1.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PcBuiApp_Client_v1.Model;

namespace PcBuiApp_Client_v1.Controllers
{
    public class ReportController
    {
        // Lấy doanh thu theo tháng từ API hoặc xử lý trên client-side
        public async Task<List<DoanhThuThang>> GetDoanhThuThangAsync()
        {
            string url = "api/orders"; // Thay đổi nếu bạn có endpoint khác

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var orders = JsonConvert.DeserializeObject<List<Order>>(result);

                    var doanhThuThang = orders
                        .Where(o => o.status == "Completed")
                        .GroupBy(o => new { o.dateCompleted.Year, o.dateCompleted.Month })
                        .Select(g => new DoanhThuThang
                        {
                            Year = g.Key.Year,
                            Month = g.Key.Month,
                        })
                        .OrderBy(o => o.Year).ThenBy(o => o.Month)
                        .ToList();


                    return doanhThuThang;
                }
                else
                {
                    throw new Exception("Không thể lấy danh sách đơn hàng.");
                }
            }
        }
    }
}
