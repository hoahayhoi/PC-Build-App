// Controllers/UserController.cs
using PcBuiApp_Client_v1.Helpers;
using PcBuiApp_Client_v1.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace PcBuiApp_Client_v1.Controllers
{
    public class UserController
    {
        // Lấy danh sách người dùng
        public async Task<List<AppUser>> GetUsersAsync()
        {
            string url = "api/customers"; // Endpoint của API để lấy danh sách người dùng

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var users = JsonConvert.DeserializeObject<List<AppUser>>(result);
                    return users;
                }
                else
                {
                    throw new System.Exception("Không thể lấy danh sách người dùng.");
                }
            }
        }

        // Controllers/UserController.cs
        // Controllers/UserController.cs
        public async Task AddUserAsync(AppUser user)
        {
            string url = "api/customers/create"; // Endpoint để tạo người dùng mới

            var userDto = new
            {
                name = user.name,
                email = user.email,
                phone = user.phone,
                address = user.address
            };

            var json = JsonConvert.SerializeObject(userDto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(url, data))
            {
                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new Exception("Không thể thêm người dùng: " + error);
                }
            }
        }


        private async Task AssignRoleToUserAsync(string username, string role)
        {
            string url = $"api/users/{username}/roles?roleName={role}";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(url, null))
            {
                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new Exception("Không thể gán vai trò cho người dùng: " + error);
                }
            }
        }

        public async Task<AppUser> GetUserByUsernameAsync(string username)
        {
            string url = $"api/users/{username}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var user = JsonConvert.DeserializeObject<AppUser>(result);
                    return user;
                }
                else
                {
                    throw new Exception("Không thể lấy thông tin người dùng.");
                }
            }
        }

        public async Task UpdateUserAsync(AppUser user)
        {
            string url = $"api/customers/edit/{user.id}"; // Endpoint để cập nhật người dùng

            var userDto = new
            {
                name = user.name,
                email = user.email,
                phone = user.phone,
                address = user.address
            };

            var json = JsonConvert.SerializeObject(userDto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync(url, data))
            {
                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new Exception("Không thể cập nhật người dùng: " + error);
                }
            }
        }

        public async Task<AppUser> GetUserByIdAsync(int? id)
        {
            string url = $"api/customers/{id}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var user = JsonConvert.DeserializeObject<AppUser>(result);
                    return user;
                }
                else
                {
                    throw new Exception("Không thể lấy thông tin người dùng.");
                }
            }
        }


        private async Task UpdateUserRoleAsync(string username, string role)
        {
            // Gọi API để cập nhật vai trò của người dùng
            string url = $"api/users/{username}/roles";
            var roleDto = new { Role = role };

            var json = JsonConvert.SerializeObject(roleDto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync(url, data))
            {
                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new System.Exception("Không thể cập nhật vai trò người dùng: " + error);
                }
            }
        }

        public async Task DeleteUserAsync(int id)
        {
            string url = $"api/customers/delete/{id}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync(url))
            {
                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new Exception("Không thể xóa người dùng: " + error);
                }
            }
        }


    }
}
