using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    public class OrderController
    {
        public static int AddOrder(OrderDto order)
        {
            using (var db = new DatabaseDataContext(Properties.Settings.Default.PCBuildConnectionString))
            {
                // Tạo đối tượng Order từ OrderDto
                var newOrder = new Order
                {
                    CustomerID = order.CustomerID,
                    CreatedOn = order.CreatedOn,
                    DateCompleted = order.DateCompleted,
                    TotalPrice = order.TotalPrice,
                    Status = order.Status,
                    SalesStaffID = order.SalesStaffID
                };

                // Thêm Order vào bảng Orders
                db.Orders.InsertOnSubmit(newOrder);

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                return newOrder.Id;
            }
        }
    }
}
