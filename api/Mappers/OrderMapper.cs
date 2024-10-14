using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Order_;
using api.Models;

namespace api.Mappers
{
    public static class OrderMapper
    {
        public static OrderDto ToOrderDto(this Order orderModel)
        {
            return new OrderDto
            {
                Id = orderModel.Id,
                CustomerID = orderModel.CustomerID,
                SalesStaffID = orderModel.SalesStaffID,
                TechnicianID = orderModel.TechnicianID,
                ConfigurationID = orderModel.ConfigurationID,
                CreatedOn = orderModel.CreatedOn,
                DateCompleted = orderModel.DateCompleted,
                TotalPrice = orderModel.TotalPrice,
                Status = orderModel.Status
            };
        }

        public static Order ToOrderFromCreateDTO(this CreateOrderRequestDto orderDto)
        {
            return new Order
            {
                CustomerID = orderDto.CustomerID,

                TotalPrice = orderDto.TotalPrice,

                Status = orderDto.Status,
            };
        }
    }
}