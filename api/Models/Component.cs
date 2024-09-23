using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Component")]
    public class Component
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public int? SupplierID { get; set; }
        public Supplier? Supplier { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    }
}