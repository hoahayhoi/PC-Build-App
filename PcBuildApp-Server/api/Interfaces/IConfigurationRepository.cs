using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Configuration_;
using api.Models;

namespace api.Interfaces
{
    public interface IConfigurationRepository
    {
        Task<List<Configuration>> GetAllAsync();
        Task<Configuration?> GetByIdAsync(int id);
        Task<Configuration> CreateAsync(Configuration configurationModel);
        Task<Configuration?> UpdateAsync(int id, UpdateConfigurationRequestDto configurationDto);
        Task<Configuration?> DeleteAsync(int id);
    }
}