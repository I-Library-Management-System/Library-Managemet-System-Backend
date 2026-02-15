using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class AppDbContext : DbContext // Responsible for managing entity objects and excuting queries
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) // constructor receives DBcontext configuration options.
        :base(options)
        {
            
        }

        public DbSet<Book> Books {get; set;} //Ef core maps this Dbset to the "Book" table.
        
    }
}