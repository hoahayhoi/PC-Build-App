using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuiApp_Client_v1.Model
{
	public class PCConfig
	{
		public int Id { get; set; }
		public string SuggestedComponents { get; set; }
		public string Purpose { get; set; }
		public string CreatedOn { get; set; }
		public string Feedback { get; set; }
		public string Image { get; set; }
		public object CustomerID { get; set; }
	}
}
