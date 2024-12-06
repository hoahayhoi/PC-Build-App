using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class CustomPermissions
    {
        public Dictionary<string, List<string>> permissions = new Dictionary<string, List<string>>()
        {
            { "Admin", new List<string> 
                {
                    "Trang chủ", 
                    "Quản lý Sản phẩm", 
                    "Quản lý Đơn hàng", 
                    "Quản lý Nhà cung cấp", 
                    "Quản lý Cấu hình",
                    "Quản lý Nhân viên", 
                    "Quản lý Khách hàng",
                    "Quản lý Kho",
                    "Phân công Lắp ráp",
                    "Quản lý Lắp ráp",
                    "Thống kê",
                    "Tài khoản",
                    "Hệ thống",
                } 
            },
            { "SalesStaff", new List<string> 
                {
                    "Trang chủ",
                    "Quản lý Đơn hàng",
                    "Quản lý Khách hàng",
                    "Quản lý Kho",
                    "Tài khoản",
                    "Hệ thống",
                }
            },
            { 
                "Technician", new List<string>
                {
                    "Trang chủ",
                    "Quản lý Lắp ráp",
                    "Tài khoản",
                    "Hệ thống",
                } 
            }
        };
    }
}
