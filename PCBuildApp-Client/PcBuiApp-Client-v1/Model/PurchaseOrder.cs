using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuiApp_Client_v1.Model
{
    public class PurchaseOrder
    {
        public int purchase_order_id { get; set; }
        public int supplierID { get; set; }
        public List<PurchaseOrderDetail> purchaseOrderDetails { get; set; }
    }
}
