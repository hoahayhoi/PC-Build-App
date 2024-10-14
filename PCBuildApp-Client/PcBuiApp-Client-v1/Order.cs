using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuiApp_Client_v1
{
    public class Order
    {
        public string id { get; set; }
        public string customerID { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime dateCompleted { get; set; }
        public string status { get; set; }
    }
}
