using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SemenjAPI.Models
{
    public class Category
    {  
        // Empty constructor -> EF
        public Category() { }

        public Category(string name, List<ProductSort> productSorts)
        {
            Name = name;
            ProductSorts = productSorts;
        }

        // Properties
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<ProductSort> ProductSorts { get; set; }

    }
}
