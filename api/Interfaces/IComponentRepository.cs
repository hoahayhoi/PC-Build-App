using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Component;
using api.Models;

namespace api.Interfaces
{
    public interface IComponentRepository
    {
        Task<List<Component>> GetComponentsByNameAsync(string name);
        Task<List<Component>> GetAllAsync();
        Task<Component?> GetByIdAsync(int id);
        Task<Component> CreateAsync(Component componentModel);
        Task<Component?> UpdateAsync(int id, UpdateComponentRequestDto componentDto);
        Task<Component?> DeleteAsync(int id);   
    }
}