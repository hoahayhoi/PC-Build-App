using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.OrderDetail
{
    public class OrderDetailDto
    {
        public int Id { get; set; }
        public int? OrderID { get; set; }
        public int? ComponentID { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
    }
}