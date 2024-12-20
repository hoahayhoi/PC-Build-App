using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Order_;
using api.Models;

namespace api.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetOrdersByTechIdAsync(string techId);
        Task<List<Order>> GetAllAsync();
        Task<Order?> GetByIdAsync(int id);
        Task<Order> CreateAsync(Order orderModel);
        Task<Order?> UpdateAsync(int id, UpdateOrderRequestDto orderDto);
        Task<Order?> DeleteAsync(int id); 
    }
}