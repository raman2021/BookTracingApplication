using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTracingApplication.Models;

namespace BookTracingApplication.Data
{
    public class BookTracingApplicationContext : DbContext
    {
        public BookTracingApplicationContext (DbContextOptions<BookTracingApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<BookTracingApplication.Models.Book> Book { get; set; }

        public DbSet<BookTracingApplication.Models.Category> Category { get; set; }

        public DbSet<BookTracingApplication.Models.CategoryType> CategoryType { get; set; }
    }
}
