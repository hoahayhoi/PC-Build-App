using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    public class CustomerController
    {
        public static List<CustomerDto> getListCustomer()
        {
            using (var db = new DatabaseDataContext(Properties.Settings.Default.PCBuildConnectionString))
            {
                // Lấy danh sách khách hàng từ bảng Customer
                var list = from customer in db.Customers // Giả sử bảng tên là Customers
                           select new CustomerDto
                           {
                               Id = customer.Id,
                               Name = customer.Name,
                               Address = customer.Address,
                               Phone = customer.Phone,
                               Email = customer.Email
                           };

                // Chuyển đổi kết quả thành một List và trả về
                return list.ToList();
            }
        }

        public static CustomerDto GetCustomerByPhone(string phone)
        {
            using (var db = new DatabaseDataContext(Properties.Settings.Default.PCBuildConnectionString))
            {
                // Truy vấn tìm khách hàng với số điện thoại chính xác
                var customer = db.Customers
                                 .Where(c => c.Phone == phone)
                                 .Select(c => new CustomerDto
                                 {
                                     Id = c.Id,
                                     Name = c.Name,
                                     Email = c.Email,
                                     Phone = c.Phone,
                                     Address = c.Address
                                 })
                                 .SingleOrDefault(); // Vì số điện thoại là duy nhất, sử dụng SingleOrDefault

                return customer; // Trả về khách hàng hoặc null nếu không tìm thấy
            }
        }

        public static void addCustomer(CustomerDto customer)
        {
            using (var db = new DatabaseDataContext(Properties.Settings.Default.PCBuildConnectionString))
            {
                // Tạo đối tượng Customer từ CustomerDto
                var newCustomer = new Customer
                {
                    Name = customer.Name,
                    Address = customer.Address,
                    Phone = customer.Phone,
                    Email = customer.Email
                };

                // Thêm khách hàng vào bảng Customers
                db.Customers.InsertOnSubmit(newCustomer);

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();
            }
        }

        public static void updateCustomer(CustomerDto customer, int Id)
        {
            using (var db = new DatabaseDataContext(Properties.Settings.Default.PCBuildConnectionString))
            {
                // Tìm khách hàng theo Id
                var existingCustomer = db.Customers.SingleOrDefault(c => c.Id == Id);

                // Kiểm tra nếu khách hàng tồn tại
                if (existingCustomer != null)
                {
                    // Cập nhật thông tin khách hàng
                    existingCustomer.Name = customer.Name;
                    existingCustomer.Address = customer.Address;
                    existingCustomer.Phone = customer.Phone;
                    existingCustomer.Email = customer.Email;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    db.SubmitChanges();
                }
                else
                {
                    // Xử lý khi không tìm thấy khách hàng, có thể thông báo lỗi hoặc thực hiện hành động khác
                    throw new Exception("Customer not found");
                }
            }
        }

        public static void deleteCustomer(int Id)
        {
            using (var db = new DatabaseDataContext(Properties.Settings.Default.PCBuildConnectionString))
            {
                // Tìm khách hàng theo Id
                var customerToDelete = db.Customers.SingleOrDefault(c => c.Id == Id);

                // Kiểm tra nếu khách hàng tồn tại
                if (customerToDelete != null)
                {
                    // Xóa khách hàng
                    db.Customers.DeleteOnSubmit(customerToDelete);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    db.SubmitChanges();
                }
                else
                {
                    // Xử lý khi không tìm thấy khách hàng, có thể thông báo lỗi hoặc thực hiện hành động khác
                    throw new Exception("Customer not found");
                }
            }
        }

        public static bool IsExist(string phone)
        {
            using (var db = new DatabaseDataContext(Properties.Settings.Default.PCBuildConnectionString))
            {
                // Tìm khách hàng có số điện thoại trùng khớp
                return db.Customers.Any(c => c.Phone == phone);
            }
        }

    }
}
