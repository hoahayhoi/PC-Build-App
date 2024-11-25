// Models/Order.cs
using Newtonsoft.Json;
using System;

namespace PcBuiApp_Client_v1.Model
{
    public class Order
    {
        public int id { get; set; }
        public int customerID { get; set; }

        [JsonProperty("dateCompleted")]
        public DateTime DateCompleted { get; set; }

        [JsonProperty("totalPrice")]
        public decimal TotalPrice { get; set; }

        public string status { get; set; }
    }

}
