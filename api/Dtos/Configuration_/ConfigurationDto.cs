using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Configuration_
{
    public class ConfigurationDto
    {
        public int Id { get; set; }
        public string SuggestedComponents { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string Feedback { get; set; } = string.Empty;
        public int? CustomerID { get; set; }
    }
}