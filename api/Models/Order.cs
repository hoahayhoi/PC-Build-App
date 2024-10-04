using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        public int? CustomerID { get; set; }
        public Customer? Customer { get; set; }

        // public int? SalesStaffID { get; set; }
        // public int? TechnicianID { get; set; }
        // public Customer? Customer { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime DateCompleted { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public string Status { get; set; } = string.Empty;

        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    }
}