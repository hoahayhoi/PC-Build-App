using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Configuration_;
using api.Dtos.Order_;
using api.Models;

namespace api.Dtos.Customer
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public List<ConfigurationDto> Configurations { get; set; } = new List<ConfigurationDto>();
        public List<OrderDto> Orders { get; set; } = new List<OrderDto>();
    }
}