using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Customer;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        private readonly ICustomerRepository _customerRepo;

        public CustomerController(ApplicationDBContext context, ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
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

            var customers = await _customerRepo.GetAllAsync();

            var customerDto = customers.Select(s => s.ToCustomerDto()).ToList();

            return Ok(customerDto);
        }

        [HttpGet("{id:int}")]
        [Authorize]

        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var customer = await _customerRepo.GetByIdAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer.ToCustomerDto());
        }

        [HttpPost("create")]
        [Authorize]

        public async Task<IActionResult> Create([FromBody] CreateCustomerRequestDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var customerModel = customerDto.ToCustomerFromCreateDTO();

            await _customerRepo.CreateAsync(customerModel);

            return CreatedAtAction(nameof(GetById), new { id = customerModel.Id }, customerModel.ToCustomerDto());
        }

        [HttpPut("edit/{id:int}")]
        [Authorize]

        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCustomerRequestDto updateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var customerModel = await _customerRepo.UpdateAsync(id, updateDto);

            if (customerModel == null)
            {
                return NotFound();
            }

            return Ok(customerModel.ToCustomerDto());
        }

        [HttpDelete("delete/{id:int}")]
        [Authorize]

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var customerModel = await _customerRepo.DeleteAsync(id);

            if (customerModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}