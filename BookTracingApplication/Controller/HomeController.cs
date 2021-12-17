using BookTracingApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTracingApplication

    { 
    [Route("Home/Index")]
    public class HomeController : ControllerBase
    {
        private IMemoryCache memoryCache;

        public HomeController(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }

        public IActionResult Index()

         
        {
            Book book;
            bool AlreadyExit = memoryCache.TryGetValue("CachedBook", out book);
            if (!AlreadyExit)
            {
                book = Book.Now;
                var cacheEntryOptions = new MemoryCacheEntryOptions();
                memoryCache.Set("CachedBook", book, cacheEntryOptions);

            }
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
