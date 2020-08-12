using SemenjAPI.Interfaces;
using SemenjAPI.Models;
using SemenjAPI.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly SemenjAPIContext semenjAPIContext;
        public ProductService(SemenjAPIContext semenjAPIContext)
        {
            this.semenjAPIContext = semenjAPIContext;
        }

        // Task za dodajanje novega produkta
        public async Task<Product> CreateProduct(ProductDto productDto, User productSeller)
        {
            var productToCreate = new Product(
                    seller: productSeller,
                    sellerId: productSeller.Id,
                    name: productDto.Name,
                    cultivationMethod: productDto.CultivationMethod,
                    category: productDto.Category,
                    quantity: productDto.Quantity,
                    price: productDto.Price,
                    priceFormat: productDto.PriceFormat
                );

            var result = await semenjAPIContext.Products.AddAsync(productToCreate);
            await semenjAPIContext.SaveChangesAsync();
            return productToCreate;
        }
            
    }
}
