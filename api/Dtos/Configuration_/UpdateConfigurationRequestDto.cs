using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Configuration_
{
    public class UpdateConfigurationRequestDto
    {
        public string SuggestedComponents { get; set; } = string.Empty;
        public string Feedback { get; set; } = string.Empty;
    }
}