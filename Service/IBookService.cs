using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto;

namespace api.Service
{
    public interface IBookService // This abstraction allows the controller to depend on an interface
    {
        Task<IEnumerable<BookResponseDto>> GetAllAsync();
        Task<BookResponseDto?> GetByIdAsync(int id);
        Task<BookResponseDto> CreateAsync(BookCreateDto bookCreateDto);
        Task<bool> UdpateAsync(int id, BookUpdateDto bookUpdateDto);
        Task<bool> DeletAsync(int id);
    }
}