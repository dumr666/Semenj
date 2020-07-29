using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.Models
{
    public class ProductSort
    {

        // Empty constructor -> EF
        public ProductSort() { }
        public ProductSort(Category category, string name, string description, List<Product> products)
        {
            Category = category;
            Name = name;
            Description = description;
            Products = products;
        }

        // Properties
        public Guid Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }

}
