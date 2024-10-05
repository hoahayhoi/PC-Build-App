using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.OrderDetail;
using api.Models;

namespace api.Interfaces
{
    public interface IOrderDetailRepository
    {
        Task<List<OrderDetail>> GetAllAsync();
        Task<OrderDetail?> GetByIdAsync(int id);
        Task<OrderDetail> CreateAsync(OrderDetail orderDetailModel);
        Task<OrderDetail?> UpdateAsync(int id, UpdateOrderDetailRequestDto orderDetailDto);
        Task<OrderDetail?> DeleteAsync(int id);
    }
}