using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuiApp_Client_v1
{
	public class Component
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
		public int Stock { get; set; }
		public int? SupplierID { get; set; }
	}
}
