using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Order_;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDBContext _context;

        public OrderRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<Order> CreateAsync(Order orderModel)
        {
            await _context.Orders.AddAsync(orderModel);
            await _context.SaveChangesAsync();
            return orderModel;
        }

        public async Task<Order?> DeleteAsync(int id)
        {
            var orderModel = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);

            if (orderModel == null)
            {
                return null;
            }

            _context.Orders.Remove(orderModel);
            await _context.SaveChangesAsync();
            return orderModel;
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order?> GetByIdAsync(int id)
        {
            return await _context.Orders.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<List<Order>> GetOrdersByTechIdAsync(string techId)
        {
            if (!string.IsNullOrEmpty(techId))
            {
                return await _context.Orders
                                    .Where(order => order.TechnicianID == techId)                                    
                                    .ToListAsync();
            }
            return new List<Order>();
        }

        public Task<bool> OrderExists(int id)
        {
            return _context.Orders.AnyAsync(c => c.Id == id);
        }

        public async Task<Order?> UpdateAsync(int id, UpdateOrderRequestDto orderDto)
        {
            var existingOrder = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);

            if (existingOrder == null)
            {
                return null;
            }

            existingOrder.CustomerID = orderDto.CustomerID;
            existingOrder.DateCompleted = orderDto.DateCompleted;
            existingOrder.TotalPrice = orderDto.TotalPrice;
            existingOrder.Status = orderDto.Status;

            await _context.SaveChangesAsync();

            return existingOrder;
        }
    }
}