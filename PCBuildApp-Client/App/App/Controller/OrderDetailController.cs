using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    public class OrderDetailController
    {
        public static void addOrderDetail(OrderDetailDto orderDetail)
        {
            using (var db = new DatabaseDataContext(Properties.Settings.Default.PCBuildConnectionString))
            {
                // Tạo đối tượng OrderDetail từ OrderDetailDto
                var newOrderDetail = new OrderDetail
                {
                    OrderID = orderDetail.OrderId,
                    Type = orderDetail.Type,
                    ComponentID = orderDetail.ComponentID,
                    ConfigurationID = orderDetail.ConfigurationID,
                    Quantity = orderDetail.Quantity,
                    Price = orderDetail.Price
                };

                // Thêm OrderDetail vào bảng OrderDetails
                db.OrderDetails.InsertOnSubmit(newOrderDetail);

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();
            }
        }
    }
}
