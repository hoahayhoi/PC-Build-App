using PcBuiApp_Client_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Models/Component.cs
namespace PcBuiApp_Client_v1.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public int supplierID { get; set; }
    }
}
