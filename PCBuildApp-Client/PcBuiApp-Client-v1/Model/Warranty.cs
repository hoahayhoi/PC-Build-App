using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuiApp_Client_v1.Model
{
    public class Warranty
    {
        public int warranty_id { get; set; }
        public DateTime start_date { get; set; }
        public string warranty_type { get; set; }
        // Các thuộc tính khác nếu có
    }
}
