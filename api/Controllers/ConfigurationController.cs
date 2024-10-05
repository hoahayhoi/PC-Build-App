using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Configuration_;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/configuration")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IConfigurationRepository _configurationRepo;

        public ConfigurationController(ApplicationDBContext context, IConfigurationRepository configurationRepo)
        {
            _configurationRepo = configurationRepo;
            _context = context;
        }

        [HttpGet]
        [Authorize]

        // [Authorize]
        // public async Task<IActionResult> GetAll([FromQuery] QueryObject query)
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var configurations = await _configurationRepo.GetAllAsync();

            var configurationDto = configurations.Select(s => s.ToConfigurationDto()).ToList();

            return Ok(configurationDto);
        }

        [HttpGet("{id:int}")]
        [Authorize]

        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var configuration = await _configurationRepo.GetByIdAsync(id);

            if (configuration == null)
            {
                return NotFound();
            }

            return Ok(configuration.ToConfigurationDto());
        }

        [HttpPost("create")]
        [Authorize]

        public async Task<IActionResult> Create([FromBody] CreateConfigurationRequestDto stockDto, int customerId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var configurationModel = stockDto.ToConfigurationFromCreateDTO(customerId);

            await _configurationRepo.CreateAsync(configurationModel);

            return CreatedAtAction(nameof(GetById), new { id = configurationModel.Id }, configurationModel.ToConfigurationDto());
        }

        [HttpPut("edit/{id:int}")]
        [Authorize]

        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateConfigurationRequestDto updateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var configurationModel = await _configurationRepo.UpdateAsync(id, updateDto);

            if (configurationModel == null)
            {
                return NotFound();
            }

            return Ok(configurationModel.ToConfigurationDto());
        }

        [HttpDelete("delete/{id:int}")]
        [Authorize]

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var configurationModel = await _configurationRepo.DeleteAsync(id);

            if (configurationModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}