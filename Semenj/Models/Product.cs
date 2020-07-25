using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Semenj.Models;   

namespace Semenj.Models
{
    public class Product
    {
        public Product () { }

        [Key]
        public Guid Id { get; set; }
        public Guid SellerId { get; set; }
        public User Seller { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string CultivationMethod { get; set; }
        public float Quantity { get; set; }
        public float Rating { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public float Price { get; set; }
        public string PriceFormat { get; set; }

    }
}
