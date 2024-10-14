using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Component;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/components")]
    [ApiController]
    public class ComponentController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        private readonly IComponentRepository _componentRepo;

        public ComponentController(ApplicationDBContext context, IComponentRepository componentRepo)
        {
            _componentRepo = componentRepo;
            _context = context;
        }


        [HttpGet("GetComponentsByName")]
        [Authorize]
        public async Task<IActionResult> GetComponentsByName([FromQuery] string name)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var components = await _componentRepo.GetComponentsByNameAsync(name);

            if (components == null)
            {
                return NotFound();
            }

            var componentDto = components.Select(s => s.ToComponentDto()).ToList();

            return Ok(componentDto);
        }


        [HttpGet]
        // [Authorize]

        // [Authorize]
        // public async Task<IActionResult> GetAll([FromQuery] QueryObject query)
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var components = await _componentRepo.GetAllAsync();

            var componentDto = components.Select(s => s.ToComponentDto()).ToList();

            return Ok(componentDto);
        }

        [HttpGet("{id:int}")]
        [Authorize]

        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var component = await _componentRepo.GetByIdAsync(id);

            if (component == null)
            {
                return NotFound();
            }

            return Ok(component.ToComponentDto());
        }

        [HttpPost("create")]
        [Authorize]

        public async Task<IActionResult> Create([FromBody] CreateComponentRequestDto componentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var componentModel = componentDto.ToComponentFromCreateDTO();

            await _componentRepo.CreateAsync(componentModel);

            return CreatedAtAction(nameof(GetById), new { id = componentModel.Id }, componentModel.ToComponentDto());
        }

        [HttpPut("edit/{id:int}")]
        [Authorize]

        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateComponentRequestDto updateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var componentModel = await _componentRepo.UpdateAsync(id, updateDto);

            if (componentModel == null)
            {
                return NotFound();
            }

            return Ok(componentModel.ToComponentDto());
        }

        [HttpDelete("delete/{id:int}")]
        [Authorize]

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var componentModel = await _componentRepo.DeleteAsync(id);

            if (componentModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}