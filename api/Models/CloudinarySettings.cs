using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class CloudinarySettings
    {
        // public CloudinarySettings(string cloudName, string apiKey, string apiSecret)
        // {
        //     CloudName = cloudName;
        //     ApiKey = apiKey;
        //     ApiSecret = apiSecret;
        // }

        public string CloudName { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
    }
}