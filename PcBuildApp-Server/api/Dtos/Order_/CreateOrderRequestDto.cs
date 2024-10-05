using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Order_
{
    public class CreateOrderRequestDto
    {
        public int? CustomerID { get; set; }
        public DateTime DateCompleted { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}