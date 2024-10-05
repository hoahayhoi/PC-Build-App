using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("OrderDetail")]

    public class OrderDetail
    {
        public int Id { get; set; }
        public int? OrderID { get; set; }
        public Order? Order { get; set; }
        public int? ComponentID { get; set; }
        public Component? Component { get; set; }
        public int Quantity { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerUnit { get; set; }
    }
}