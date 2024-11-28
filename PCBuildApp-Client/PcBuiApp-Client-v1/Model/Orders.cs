using PcBuiApp_Client_v1.Model;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PcBuiApp_Client_v1.Models
{
	public class Orders
	{
		public int Id { get; set; }
		public int? CustomerID { get; set; }
		public int? SalesStaffID { get; set; }
		public int? TechnicianID { get; set; }
		public int ConfigurationID { get; set; }
		public DateTime CreatedOn { get; set; }
		public DateTime? DateCompleted { get; set; }
		public decimal TotalPrice { get; set; }
		public string Status { get; set; }
		public List<OrderDetail> Details { get; set; }
	}
}
