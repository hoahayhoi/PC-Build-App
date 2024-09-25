using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Supplier;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/supplier")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        private readonly ISupplierRepository _supplierRepo;

        public SupplierController(ApplicationDBContext context, ISupplierRepository supplierRepo)
        {
            _supplierRepo = supplierRepo;
            _context = context;
        }


        [HttpGet]
        // [Authorize]
        // public async Task<IActionResult> GetAll([FromQuery] QueryObject query)
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var suppliers = await _supplierRepo.GetAllAsync();

            var supplierDto = suppliers.Select(s => s.ToSupplierDto()).ToList();

            return Ok(supplierDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var supplier = await _supplierRepo.GetByIdAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return Ok(supplier.ToSupplierDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSupplierRequestDto stockDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var supplierModel = stockDto.ToSupplierFromCreateDTO();

            await _supplierRepo.CreateAsync(supplierModel);

            return CreatedAtAction(nameof(GetById), new { id = supplierModel.Id }, supplierModel.ToSupplierDto());
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateSupplierRequestDto updateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var supplierModel = await _supplierRepo.UpdateAsync(id, updateDto);

            if (supplierModel == null)
            {
                return NotFound();
            }

            return Ok(supplierModel.ToSupplierDto());
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var supplierModel = await _supplierRepo.DeleteAsync(id);

            if (supplierModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}