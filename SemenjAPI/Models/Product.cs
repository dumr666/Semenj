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

        public Product(User seller, Guid sellerId, string name, 
            string cultivationMethod, int category, float quantity, 
            float price, string priceFormat)
        {
            Seller = seller;
            SellerId = sellerId;
            Name = name;
            CultivationMethod = cultivationMethod;
            Category = category;
            Quantity = quantity;
            Price = price;
            PriceFormat = priceFormat;
        }

        [Key]
        public Guid Id { get; set; } = new Guid();
        //public Guid SellerId { get; set; }
        public Guid SellerId { get; set; }
        public User Seller { get; set; }
        public string Name { get; set; }
        public string CultivationMethod { get; set; }
        public int Category { get; set; }
        public float Quantity { get; set; }
        public float Rating { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        public float Price { get; set; }
        public string PriceFormat { get; set; }

    }
}
