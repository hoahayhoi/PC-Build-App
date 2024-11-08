using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Models/AppUser.cs
namespace PcBuiApp_Client_v1.Models
{
    public class AppUser
    {
        public string Id { get; set; }          // ID của người dùng
        public string UserName { get; set; }    // Tên đăng nhập
        public string Email { get; set; }       // Email
        public string PhoneNumber { get; set; } // Số điện thoại
        public string Name { get; set; }        // Tên đầy đủ
        public string Role { get; set; }        // Vai trò (Admin, SalesStaff, Technician)
        public string Password { get; set; }        // Vai trò (Admin, SalesStaff, Technician)
    }
}
