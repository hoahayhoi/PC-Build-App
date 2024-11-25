using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Component;
using api.Models;

namespace api.Mappers
{
    public static class ComponentMapper
    {
        public static ComponentDto ToComponentDto(this Component componentModel)
        {
            return new ComponentDto
            {
                Id = componentModel.Id,
                Name = componentModel.Name,
                Category = componentModel.Category,
                Price = componentModel.Price,
                Stock = componentModel.Stock,
                SupplierID = componentModel.SupplierID,
                Image = componentModel.Image,
                OrderDetails = componentModel.OrderDetails.Select(c => c.ToOrderDetailDto()).ToList()
            };
        }

        public static Component ToComponentFromCreateDTO(this CreateComponentRequestDto componentDto)
        {
            return new Component
            {
                Name = componentDto.Name,
                Category = componentDto.Category,
                Price = componentDto.Price,
                Stock = componentDto.Stock,
                Image = componentDto.Image
            };
        }
    }
}