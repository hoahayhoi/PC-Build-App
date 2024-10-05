using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly ApplicationDBContext _context;

        public ComponentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Component>> GetAllAsync()
        {
            return await _context.Components.Include(c => c.Supplier).ToListAsync();
        }

        public async Task<Component?> GetByIdAsync(int id)
        {
            return await _context.Components
                .Include(c => c.Supplier)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Component> CreateAsync(Component component)
        {
            _context.Components.Add(component);
            await _context.SaveChangesAsync();
            return component;
        }

        public async Task<Component?> UpdateAsync(int id, Component updatedComponent)
        {
            var existingComponent = await _context.Components.FindAsync(id);
            if (existingComponent == null) return null;

            existingComponent.Name = updatedComponent.Name;
            existingComponent.Category = updatedComponent.Category;
            existingComponent.Price = updatedComponent.Price;
            existingComponent.Stock = updatedComponent.Stock;
            existingComponent.SupplierID = updatedComponent.SupplierID;

            await _context.SaveChangesAsync();
            return existingComponent;
        }

        public async Task<Component?> DeleteAsync(int id)
        {
            var component = await _context.Components.FindAsync(id);
            if (component == null) return null;

            _context.Components.Remove(component);
            await _context.SaveChangesAsync();
            return component;
        }
    }
}
