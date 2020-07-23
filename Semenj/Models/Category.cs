using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Semenj.Models;

namespace Semenj.Models
{
    public class Category
    {
        public Category() { }
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        
    }
}
