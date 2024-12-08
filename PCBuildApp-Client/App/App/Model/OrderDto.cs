using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class OrderDto
    {
        public OrderDto(int customerID, DateTime createdOn, DateTime dateCompleted, decimal totalPrice, string status, int salesStaffID)
        {
            CustomerID = customerID;
            CreatedOn = createdOn;
            DateCompleted = dateCompleted;
            TotalPrice = totalPrice;
            Status = status;
            SalesStaffID = salesStaffID;
        }

        public OrderDto()
        {
        }

        public int Id { get; set; }
        public int CustomerID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DateCompleted { get; set;}
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public int SalesStaffID { get; set; }

    }
}
