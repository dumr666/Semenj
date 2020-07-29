using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.Models
{
    public class Product
    {
        // Empty constructor -> EF
        public Product() { }

        public Product(User seller, Homestead homestead, string name, ProductSort productSort, string cultivationMethod, float quantity, float rating, float price, string priceFormat)
        {
            Seller = seller;
            Homestead = homestead;
            Name = name;
            ProductSort = productSort;
            CultivationMethod = cultivationMethod;
            Quantity = quantity;
            Rating = rating;
            Price = price;
            PriceFormat = priceFormat;
        }

        [Key]
        public Guid Id { get; set; }
        public Guid SellerId { get; set; }
        public User Seller { get; set; }
        public Guid HomesteadId { get; set; }
        public Homestead Homestead { get; set; }
        public string Name { get; set; }
        public ProductSort ProductSort { get; set; }
        public string CultivationMethod { get; set; }
        public float Quantity { get; set; }
        public float Rating { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        public float Price { get; set; }
        public string PriceFormat { get; set; }

    }
}
