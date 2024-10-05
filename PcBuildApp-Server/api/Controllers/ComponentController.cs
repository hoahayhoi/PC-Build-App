using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/components")]
    [ApiController]
    public class ComponentController : ControllerBase
    {
        private readonly IComponentRepository _componentRepo;

        public ComponentController(IComponentRepository componentRepo)
        {
            _componentRepo = componentRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var components = await _componentRepo.GetAllAsync();

            if (components == null || !components.Any())
            {
                return NotFound("No components found.");
            }

            return Ok(components);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var component = await _componentRepo.GetByIdAsync(id);

            if (component == null)
            {
                return NotFound($"Component with ID {id} not found.");
            }

            return Ok(component);
        }

        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> Create([FromBody] Component component)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdComponent = await _componentRepo.CreateAsync(component);

            return CreatedAtAction(nameof(GetById), new { id = createdComponent.Id }, createdComponent);
        }

        [HttpPut("{id:int}")]
        //[Authorize]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Component updatedComponent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var component = await _componentRepo.UpdateAsync(id, updatedComponent);

            if (component == null)
            {
                return NotFound($"Component with ID {id} not found.");
            }

            return Ok(component);
        }

        [HttpDelete("{id:int}")]
        //[Authorize]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var component = await _componentRepo.DeleteAsync(id);

            if (component == null)
            {
                return NotFound($"Component with ID {id} not found.");
            }

            return NoContent();
        }
    }
}
