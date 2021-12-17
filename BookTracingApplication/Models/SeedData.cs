using BookTracingApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTracingApplication.Models
{
    public class SeedData
    {
       
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new BookTracingApplicationContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<BookTracingApplicationContext>>()))
                {
                    // Look for any movies.
                    if (context.Book.Any())
                    {
                        return;   // DB has been seeded
                    }

                    context.Book.AddRange(
                        new Book
                        {
                            ISBM = "When Harry",
                            BookTitle = "HELLO",
                            Category = 2,
                            Author = "SLEEP"
                        },

                          new Book
                          {
                              ISBM = "When Harry Met Sally",
                              BookTitle = "HELLO",
                              Category = 2,
                              Author = "SLEEP"
                          },
                            new Book
                            {
                                ISBM = "When Harry Met Sally",
                                BookTitle = "HELLO",
                                Category = 2,
                                Author = "SLEEP"
                            },
                              new Book
                              {
                                  ISBM = "When Harry Met Sally",
                                  BookTitle = "HELLO",
                                  Category = 2,
                                  Author = "SLEEP"
                              }


                    );
                    context.SaveChanges();
                }
            }
        }
    }

