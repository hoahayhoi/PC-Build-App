using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.OrderDetail;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {

        private readonly ApplicationDBContext _context;

        public OrderDetailRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        
        public async Task<OrderDetail> CreateAsync(OrderDetail orderDetailDetailModel)
        {
            await _context.OrderDetails.AddAsync(orderDetailDetailModel);
            await _context.SaveChangesAsync();
            return orderDetailDetailModel;
        }

        public Task<Order> CreateAsync(Order orderModel)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDetail?> DeleteAsync(int id)
        {
            var orderDetailDetailModel = await _context.OrderDetails.FirstOrDefaultAsync(x => x.Id == id);

            if (orderDetailDetailModel == null)
            {
                return null;
            }

            _context.OrderDetails.Remove(orderDetailDetailModel);
            await _context.SaveChangesAsync();
            return orderDetailDetailModel;
        }

        public async Task<List<OrderDetail>> GetAllAsync()
        {
            return await _context.OrderDetails.ToListAsync();
        }

        public async Task<OrderDetail?> GetByIdAsync(int id)
        {
            return await _context.OrderDetails.FirstOrDefaultAsync(i => i.Id == id);
        }

        public Task<bool> OrderDetailExists(int id)
        {
            return _context.OrderDetails.AnyAsync(c => c.Id == id);
        }

        public async Task<OrderDetail?> UpdateAsync(int id, UpdateOrderDetailRequestDto orderDetailDto)
        {
            var existingOrderDetail = await _context.OrderDetails.FirstOrDefaultAsync(x => x.Id == id);

            if (existingOrderDetail == null)
            {
                return null;
            }

            existingOrderDetail.Quantity = orderDetailDto.Quantity;
            existingOrderDetail.PricePerUnit = orderDetailDto.PricePerUnit;

            await _context.SaveChangesAsync();

            return existingOrderDetail;
        }

    }
}