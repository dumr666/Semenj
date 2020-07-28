using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Semenj.Models;

namespace Semenj.Models
{
    public class ProductSort
    {
        public ProductSort() { }
        
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
