using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Component;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly ApplicationDBContext _context;

        public ComponentRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<Component> CreateAsync(Component componentModel)
        {
            await _context.Components.AddAsync(componentModel);
            await _context.SaveChangesAsync();
            return componentModel;
        }

        public async Task<Component?> DeleteAsync(int id)
        {
            var componentModel = await _context.Components.FirstOrDefaultAsync(x => x.Id == id);

            if (componentModel == null)
            {
                return null;
            }

            _context.Components.Remove(componentModel);
            await _context.SaveChangesAsync();
            return componentModel;
        }

        public async Task<List<Component>> GetAllAsync()
        {
            return await _context.Components
                                 .Include(o => o.OrderDetails)
                                 .ToListAsync();
        }

        public async Task<Component?> GetByIdAsync(int id)
        {
            return await _context.Components.Include(o => o.OrderDetails)
                                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public Task<bool> ComponentExists(int id)
        {
            return _context.Components.AnyAsync(c => c.Id == id);
        }

        public async Task<Component?> UpdateAsync(int id, UpdateComponentRequestDto componentDto)
        {
            var existingComponent = await _context.Components.FirstOrDefaultAsync(x => x.Id == id);

            if (existingComponent == null)
            {
                return null;
            }

            existingComponent.Name = componentDto.Name;
            existingComponent.Category = componentDto.Category;
            existingComponent.Price = componentDto.Price;
            existingComponent.Stock = componentDto.Stock;

            await _context.SaveChangesAsync();

            return existingComponent;
        }

        public async Task<List<Component>> GetComponentsByNameAsync(string name)
        {
            return await _context.Components
                                .Where(c => c.Name.ToLower().Contains(name.ToLower()))
                                .ToListAsync();
        }
    }
}