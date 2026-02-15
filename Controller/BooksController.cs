using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto;
using api.Service;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _service;

        public BooksController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _service.GetByIdAsync(id);
            if(book == null) return NotFound();
            
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Creat(BookCreateDto dto)
        {
            var create = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = create.Id},create);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, BookUpdateDto bookUpdateDto)
        {
            var Update = await _service.UdpateAsync(id,bookUpdateDto);
            if(!Update) return NotFound();

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await _service.DeletAsync(id);
            if(delete == null) return NotFound();

            return NoContent();
        }
        
    }
}