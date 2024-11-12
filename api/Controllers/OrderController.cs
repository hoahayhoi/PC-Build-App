using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Order_;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        private readonly IOrderRepository _orderRepo;

        public OrderController(ApplicationDBContext context, IOrderRepository orderRepo)
        {
            _orderRepo = orderRepo;
            _context = context;
        }



        [HttpGet("GetOrdersByTechId/{techId}")]
        // [Authorize]
        public async Task<IActionResult> GetOrdersByTechId([FromRoute] string? techId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orders = await _orderRepo.GetOrdersByTechIdAsync(techId);

            var orderDto = orders.Select(s => s.ToOrderDto()).ToList();

            return Ok(orderDto);
        }



        [HttpGet]
        // [Authorize]

        // [Authorize]
        // public async Task<IActionResult> GetAll([FromQuery] QueryObject query)
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orders = await _orderRepo.GetAllAsync();

            var orderDto = orders.Select(s => s.ToOrderDto()).ToList();

            return Ok(orderDto);
        }

        [HttpGet("{id:int}")]
        // [Authorize]

        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var order = await _orderRepo.GetByIdAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order.ToOrderDto());
        }

        [HttpPost("create")]
        // [Authorize]

        public async Task<IActionResult> Create([FromBody] CreateOrderRequestDto stockDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orderModel = stockDto.ToOrderFromCreateDTO();

            await _orderRepo.CreateAsync(orderModel);

            return CreatedAtAction(nameof(GetById), new { id = orderModel.Id }, orderModel.ToOrderDto());
        }

        [HttpPut("edit/{id:int}")]
        // [Authorize]

        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateOrderRequestDto updateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orderModel = await _orderRepo.UpdateAsync(id, updateDto);

            if (orderModel == null)
            {
                return NotFound();
            }

            return Ok(orderModel.ToOrderDto());
        }

        [HttpDelete("delete/{id:int}")]
        // [Authorize]

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orderModel = await _orderRepo.DeleteAsync(id);

            if (orderModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}