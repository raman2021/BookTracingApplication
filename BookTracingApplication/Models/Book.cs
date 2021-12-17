using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookTracingApplication.Models
{
    public class Book
    {
        public static Book Now { get; internal set; }
        [Key]
        public string ISBM { get; set; }
        public string BookTitle { get; set; }
        public int Category { get; set; }
        public string Author { get; set; }
       

    }
}
