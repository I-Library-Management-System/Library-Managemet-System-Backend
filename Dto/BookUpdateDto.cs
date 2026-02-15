using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto
{
    public class BookUpdateDto // represent the data the client is a allowed to modify.
    {
     [Required]
     [MaxLength(200)]
     public string Title { get; set; } = string.Empty;

     [Required]
     [MaxLength(200)]
     public string Author { get; set; } = string.Empty;
     
     [MaxLength(1000)]
     public string? Description { get; set; }
     public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
     
     public DateTime? UpdateAt{ get; set; }
    }
}