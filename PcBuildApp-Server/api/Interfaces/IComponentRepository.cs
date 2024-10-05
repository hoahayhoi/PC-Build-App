using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    public interface IComponentRepository
    {
        Task<IEnumerable<Component>> GetAllAsync();
        Task<Component?> GetByIdAsync(int id);
        Task<Component> CreateAsync(Component component);
        Task<Component?> UpdateAsync(int id, Component updatedComponent);
        Task<Component?> DeleteAsync(int id);
    }
}
