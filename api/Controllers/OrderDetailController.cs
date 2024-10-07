using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.OrderDetail;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/orderDetails")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        private readonly IOrderDetailRepository _orderDetailRepo;

        public OrderDetailController(ApplicationDBContext context, IOrderDetailRepository orderDetailRepo)
        {
            _orderDetailRepo = orderDetailRepo;
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

            var orderDetails = await _orderDetailRepo.GetAllAsync();

            var orderDetailDto = orderDetails.Select(s => s.ToOrderDetailDto()).ToList();

            return Ok(orderDetailDto);
        }

        [HttpGet("{id:int}")]
        [Authorize]

        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orderDetail = await _orderDetailRepo.GetByIdAsync(id);

            if (orderDetail == null)
            {
                return NotFound();
            }

            return Ok(orderDetail.ToOrderDetailDto());
        }

        [HttpPost("create")]
        [Authorize]

        public async Task<IActionResult> Create([FromBody] CreateOrderDetailRequestDto stockDto, int orderId, int componentId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orderDetailModel = stockDto.ToOrderDetailFromCreateDTO(orderId, componentId);

            await _orderDetailRepo.CreateAsync(orderDetailModel);

            return CreatedAtAction(nameof(GetById), new { id = orderDetailModel.Id }, orderDetailModel.ToOrderDetailDto());
        }

        [HttpPut("edit/{id:int}")]
        [Authorize]

        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateOrderDetailRequestDto updateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orderDetailModel = await _orderDetailRepo.UpdateAsync(id, updateDto);

            if (orderDetailModel == null)
            {
                return NotFound();
            }

            return Ok(orderDetailModel.ToOrderDetailDto());
        }

        [HttpDelete("delete/{id:int}")]
        [Authorize]

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orderDetailModel = await _orderDetailRepo.DeleteAsync(id);

            if (orderDetailModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}