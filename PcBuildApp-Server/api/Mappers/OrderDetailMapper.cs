using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.OrderDetail;
using api.Models;

namespace api.Mappers
{
    public static class OrderDetailMapper
    {
        public static OrderDetailDto ToOrderDetailDto(this OrderDetail orderDetailModel)
        {
            return new OrderDetailDto
            {
                Id = orderDetailModel.Id,
                OrderID = orderDetailModel.OrderID,
                ComponentID = orderDetailModel.ComponentID,
                Quantity = orderDetailModel.Quantity,
                PricePerUnit = orderDetailModel.PricePerUnit,
            };
        }

        public static OrderDetail ToOrderDetailFromCreateDTO(this CreateOrderDetailRequestDto orderDetailDto, int orderId, int componentId)
        {
            return new OrderDetail
            {
                Quantity = orderDetailDto.Quantity,
                PricePerUnit = orderDetailDto.PricePerUnit,
                OrderID = orderId,
                ComponentID = componentId
            };
        }
    }
}