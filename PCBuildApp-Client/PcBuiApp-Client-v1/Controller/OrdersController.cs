using Newtonsoft.Json;
using PcBuiApp_Client_v1.Helpers;
using PcBuiApp_Client_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuiApp_Client_v1.Controller
{
    public class OrdersController
    {
        public async Task<List<Orders>> GetAllOrdersAsync()
        {
            string url = "api/orders";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var orders = JsonConvert.DeserializeObject<List<Orders>>(result);
                    return orders;
                }
                else
                {
                    throw new System.Exception("Không thể lấy danh sách đơn hàng.");
                }
            }
        }

        public async Task<Orders> GetOrderByIdAsync(int id)
        {
            string url = $"api/orders/{id}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var order = JsonConvert.DeserializeObject<Orders>(result);
                    return order;
                }
                else
                {
                    throw new System.Exception("Không thể lấy thông tin đơn hàng.");
                }
            }
        }

        public async Task<List<Orders>> GetOrdersByTechIdAsync(int id)
        {
            string url = $"api/orders/GetOrdersByTechId/{id}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var orders = JsonConvert.DeserializeObject<List<Orders>>(result);
                    return orders;
                }
                else
                {
                    throw new System.Exception("Không thể lấy danh sách đơn hàng.");
                }
            }
        }

        public async Task DeleteOrderAsync(int id)
        {
            string url = $"api/orders/delete/{id}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync(url))
            {
                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new Exception("Không thể xóa đơn hàng: " + error);
                }
            }
        }

        public async Task UpdateOrderInfoAsync(Orders order)
        {
            string url = $"api/orders/edit/{order.Id}";

            var newOrder = new
            {
                //DateCompleted = order.DateCompleted,
                Status = order.Status,
                TotalPrice = order.TotalPrice
            };

            var json = JsonConvert.SerializeObject(newOrder);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync(url, data))
            {
                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new Exception("Không thể cập nhật đơn hàng: " + error);
                }
            }
        }
    }
}
