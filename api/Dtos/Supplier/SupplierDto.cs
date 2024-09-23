using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Component;
using api.Models;

namespace api.Dtos.Supplier
{
    public class SupplierDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<ComponentDto> Components { get; set; } = new List<ComponentDto>();
    }
}