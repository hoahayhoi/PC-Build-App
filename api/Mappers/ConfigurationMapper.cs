using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Configuration_;
using api.Models;

namespace api.Mappers
{
    public static class ConfigurationMapper
    {
        public static ConfigurationDto ToConfigurationDto(this Configuration configurationModel)
        {
            return new ConfigurationDto
            {
                Id = configurationModel.Id,
                SuggestedComponents = configurationModel.SuggestedComponents,
                Purpose = configurationModel.Purpose,
                CreatedOn = configurationModel.CreatedOn,
                Feedback = configurationModel.Feedback,
                CustomerID = configurationModel.CustomerID,
            };
        }

        public static Configuration ToConfigurationFromCreateDTO(this CreateConfigurationRequestDto configurationDto, int customerID)
        {
            return new Configuration
            {
                SuggestedComponents = configurationDto.SuggestedComponents,

                Feedback = configurationDto.Feedback,

                CustomerID = customerID,
            };
        }
    }
}