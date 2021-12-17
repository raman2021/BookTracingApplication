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
    public class DetailsModel : PageModel
    {
        private readonly BookTracingApplication.Data.BookTracingApplicationContext _context;

        public DetailsModel(BookTracingApplication.Data.BookTracingApplicationContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ISBM == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
