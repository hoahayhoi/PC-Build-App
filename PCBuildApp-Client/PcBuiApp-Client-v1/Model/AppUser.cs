// Models/AppUser.cs
using System.Configuration;

namespace PcBuiApp_Client_v1.Models
{
    public class AppUser
    {
        public int id { get; set; }                     // ID của người dùng
        public string name { get; set; }                // Tên người dùng
        public string email { get; set; }               // Email
        public string phone { get; set; }               // Số điện thoại
        public string address { get; set; }             // Địa chỉ
        public List<Configuration> configurations { get; set; } // Danh sách cấu hình (nếu cần)
        public List<Order> orders { get; set; }         // Danh sách đơn hàng (nếu cần)
    }
}
