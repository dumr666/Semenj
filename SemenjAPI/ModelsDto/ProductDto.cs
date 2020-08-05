using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.ModelsDto
{
    public class ProductDto
    {
        public Guid SellerId { get; set; }
        public string Name { get; set; }
        public string CultivationMethod { get; set; }
        public float Quantity { get; set; }
        public float Price { get; set; }
        public string PriceFormat { get; set; }
        public int Category { get; set; }
        public string Error { get; set; }
    }
}
