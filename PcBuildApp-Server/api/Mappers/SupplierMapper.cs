using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Supplier;
using api.Models;

namespace api.Mappers
{
    public static class SupplierMapper
    {
        public static SupplierDto ToSupplierDto(this Supplier supplierModel)
        {
            return new SupplierDto
            {
                Id = supplierModel.Id,
                Name = supplierModel.Name,
                Contact = supplierModel.Contact,
                Address = supplierModel.Address,
                Components = supplierModel.Components.Select(c => c.ToComponentDto()).ToList()
            };
        }

        public static Supplier ToSupplierFromCreateDTO(this CreateSupplierRequestDto supplierDto)
        {
            return new Supplier
            {
                Name = supplierDto.Name,
                Contact = supplierDto.Contact,
                Address = supplierDto.Address,
            };
        }
    }
}