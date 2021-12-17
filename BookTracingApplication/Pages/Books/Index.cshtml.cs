using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTracingApplication.Data;
using BookTracingApplication.Models;

namespace BookTracingApplication.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookTracingApplication.Data.BookTracingApplicationContext _context;

        public IndexModel(BookTracingApplication.Data.BookTracingApplicationContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
