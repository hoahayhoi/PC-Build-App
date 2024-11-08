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
            string url = "api/users"; // Endpoint của API để lấy danh sách người dùng

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
        public async Task AddUserAsync(AppUser user)
        {
            string url = "api/account/register"; // Endpoint để đăng ký người dùng
            var registerDto = new
            {
                Username = user.UserName,
                Email = user.Email,
                Password = user.Password
            };

            var json = JsonConvert.SerializeObject(registerDto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(url, data))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Thêm thành công
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new Exception("Không thể thêm người dùng: " + error);
                }
            }

            // Sau khi đăng ký thành công, cập nhật thông tin khác như Role
            await AssignRoleToUserAsync(user.UserName, user.Role);
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
            string url = $"api/users/{user.UserName}";

            // Tạo đối tượng chứa thông tin cần cập nhật
            var updateDto = new
            {
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Name = user.Name
            };

            var json = JsonConvert.SerializeObject(updateDto);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync(url, data))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Cập nhật thành công
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new System.Exception("Không thể cập nhật người dùng: " + error);
                }
            }

            // Cập nhật vai trò nếu có thay đổi
            await UpdateUserRoleAsync(user.UserName, user.Role);
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

        public async Task DeleteUserAsync(string username)
        {
            string url = $"api/users/{username}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Xóa thành công
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    throw new Exception("Không thể xóa người dùng: " + error);
                }
            }
        }

    }
}
