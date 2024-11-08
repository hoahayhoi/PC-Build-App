// Controllers/AccountController.cs
using PcBuiApp_Client_v1.Helpers;
using PcBuiApp_Client_v1.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PcBuiApp_Client_v1.Controller
{
    public class AccountController
    {
        public async Task<UserResponse> LoginAsync(LoginDto loginDto)
        {
            string url = "api/account/login"; // Endpoint của API

            var json = JsonConvert.SerializeObject(loginDto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(url, data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var userResponse = JsonConvert.DeserializeObject<UserResponse>(result);
                    return userResponse;
                }
                else
                {
                    // Xử lý lỗi, ví dụ: sai tên đăng nhập hoặc mật khẩu
                    throw new System.Exception("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin.");
                }
            }
        }
    }
}
