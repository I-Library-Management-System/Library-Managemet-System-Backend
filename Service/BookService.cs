using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dto;
using api.Mapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace api.Service
{
    public class BookService : IBookService
    {

        private readonly AppDbContext _context;
        public BookService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<BookResponseDto> CreateAsync(BookCreateDto bookCreateDto)
        {
            var book = BookMapper.ToEntity(bookCreateDto);

            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            
           return BookMapper.ToResponseDto(book);
        }

        public async Task<bool> DeletAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if(book == null) return false;

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return true;
            
        }

        public async Task<IEnumerable<BookResponseDto>> GetAllAsync()
        {
            var book = await _context.Books.ToListAsync();
            return book.Select(BookMapper.ToResponseDto);
        
        }

        public async Task<BookResponseDto?> GetByIdAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if(book == null) return null;

            return BookMapper.ToResponseDto(book);
        }

        public async Task<bool> UdpateAsync(int id, BookUpdateDto bookUpdateDto)
        {
            var book = await _context.Books.FindAsync(id);
            if(book == null) return false;

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            
            return true;
        }
    }
}