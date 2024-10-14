using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Configuration_;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private readonly ApplicationDBContext _context;

        public ConfigurationRepository(ApplicationDBContext context) 
        {
            _context = context;
        }
        public async Task<Configuration> CreateAsync(Configuration configurationModel)
        {
            await _context.Configurations.AddAsync(configurationModel);
            await _context.SaveChangesAsync();
            return configurationModel;
        }

        public async Task<Configuration?> DeleteAsync(int id)
        {
            var configurationModel = await _context.Configurations.FirstOrDefaultAsync(x => x.Id == id);

            if (configurationModel == null)
            {
                return null;
            }

            _context.Configurations.Remove(configurationModel);
            await _context.SaveChangesAsync();
            return configurationModel;
        }

        public async Task<List<Configuration>> GetAllAsync()
        {
            return await _context.Configurations.ToListAsync();
        }

        public async Task<Configuration?> GetByIdAsync(int id)
        {
            return await _context.Configurations.FirstOrDefaultAsync(i => i.Id == id);
        }

        public Task<bool> ConfigurationExists(int id)
        {
            return _context.Configurations.AnyAsync(c => c.Id == id);
        }

        public async Task<Configuration?> UpdateAsync(int id, UpdateConfigurationRequestDto configurationDto)
        {
            var existingConfiguration = await _context.Configurations.FirstOrDefaultAsync(x => x.Id == id);

            if (existingConfiguration == null)
            {
                return null;
            }

            existingConfiguration.SuggestedComponents = configurationDto.SuggestedComponents;
            existingConfiguration.Feedback = configurationDto.Feedback;

            await _context.SaveChangesAsync();

            return existingConfiguration;
        }

    }
}