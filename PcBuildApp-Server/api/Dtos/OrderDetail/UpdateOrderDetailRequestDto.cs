using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.OrderDetail
{
    public class UpdateOrderDetailRequestDto
    {
        public int Quantity { get; set; }

        public decimal PricePerUnit { get; set; }
    }
}