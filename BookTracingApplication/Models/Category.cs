using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookTracingApplication.Models
{
    public class Category
    {

        [Key]
        public string NameToken { get; set; }
        public int Type { get; set; }
       
        public string Description { get; set; }
    }
}
