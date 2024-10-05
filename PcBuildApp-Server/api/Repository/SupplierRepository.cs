using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Supplier;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDBContext _context;

        public SupplierRepository(ApplicationDBContext context)
        {
            _context = context;
        }


        public async Task<Supplier> CreateAsync(Supplier supplierModel)
        {
            await _context.Suppliers.AddAsync(supplierModel);
            await _context.SaveChangesAsync();
            return supplierModel;
        }

        public async Task<Supplier?> DeleteAsync(int id)
        {
            var supplierModel = await _context.Suppliers.FirstOrDefaultAsync(x => x.Id == id);

            if (supplierModel == null)
            {
                return null;
            }

            _context.Suppliers.Remove(supplierModel);
            await _context.SaveChangesAsync();
            return supplierModel;
        }

        public async Task<List<Supplier>> GetAllAsync()
        {
            return await _context.Suppliers
                                 .Include(c => c.Components)
                                 .ToListAsync();
        }


        public async Task<Supplier?> GetByIdAsync(int id)
        {
            return await _context.Suppliers.Include(c => c.Components).FirstOrDefaultAsync(i => i.Id == id);
        }

        public Task<bool> SupplierExists(int id)
        {
            return _context.Suppliers.AnyAsync(s => s.Id == id);
        }

        public async Task<Supplier?> UpdateAsync(int id, UpdateSupplierRequestDto supplierDto)
        {
            var existingSupplier = await _context.Suppliers.FirstOrDefaultAsync(x => x.Id == id);

            if (existingSupplier == null)
            {
                return null;
            }

            existingSupplier.Name = supplierDto.Name;
            existingSupplier.Contact = supplierDto.Contact;
            existingSupplier.Address = supplierDto.Address;

            await _context.SaveChangesAsync();

            return existingSupplier;
        }
    }
}