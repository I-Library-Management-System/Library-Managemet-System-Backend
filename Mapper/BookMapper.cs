using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto;
using api.Model;

namespace api.Mapper
{
    public class BookMapper
    {
        public static Book ToEntity(BookCreateDto dto)
        {
            return new Book
            {
             Title = dto.Title,
             Author = dto.Author,
             Description = dto.Description,
             CreatedAt = DateTime.UtcNow
            };
        }

        public static BookResponseDto ToResponseDto(Book book)
        {
            return new BookResponseDto
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Description = book.Description,
                CreatedAt = book.CreatedAt
            };
        }

        public static void UpdateEntity(Book book , BookUpdateDto bookUpdateDto)
        {
            book.Title = bookUpdateDto.Title;
            book.Author = bookUpdateDto.Author;
            book.Description = bookUpdateDto.Description;
            book.UpdatedAt = DateTime.UtcNow;
        }
    }
}