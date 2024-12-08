using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class OrderDetailDto
    {
        public OrderDetailDto(int orderId, string type, int? componentID, int? configurationID, int quantity, decimal price)
        {
            OrderId = orderId;
            Type = type;
            ComponentID = componentID;
            ConfigurationID = configurationID;
            Quantity = quantity;
            Price = price;
        }

        public OrderDetailDto()
        {
        }

        public int Id { get; set; }
        public int OrderId { get; set; }

        public string Type { get; set; }

        public int? ComponentID { get; set; }

        public int? ConfigurationID { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
