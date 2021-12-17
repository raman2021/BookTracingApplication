using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTracingApplication.Data;
using BookTracingApplication.Models;

namespace BookTracingApplication.Pages.Ctype
{
    public class DetailsModel : PageModel
    {
        private readonly BookTracingApplication.Data.BookTracingApplicationContext _context;

        public DetailsModel(BookTracingApplication.Data.BookTracingApplicationContext context)
        {
            _context = context;
        }

        public CategoryType CategoryType { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryType = await _context.CategoryType.FirstOrDefaultAsync(m => m.Type == id);

            if (CategoryType == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
