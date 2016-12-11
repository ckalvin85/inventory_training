using System;
using System.Collections.Generic;
using System.Linq;

namespace inventory_api.Models{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository(InventoryContext inventoryContext) {
            this._inventoryContext = inventoryContext;
        }

        private InventoryContext _inventoryContext;

        public ProductDto Add(ProductDto productDto)
        {
            Product product = map(productDto);
            product.Id = Guid.NewGuid();

            this._inventoryContext.Add(product);
            this._inventoryContext.SaveChanges();

            return mapDTO(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            List<Product> products = this._inventoryContext.Products.ToList();
            List<ProductDto> productResults = new List<ProductDto>();

            foreach(Product product in products) {
                productResults.Add(mapDTO(product));            
            }

            return productResults;
        }

        public ProductDto mapDTO(Product product) {
            ProductDto productResultDTO = new ProductDto();
            productResultDTO.Id = product.Id;
            productResultDTO.Name = product.Name;
            productResultDTO.SellingPrice = product.SellingPrice;
            productResultDTO.CostPrice = product.CostPrice;
            return productResultDTO;
        }

        public Product map(ProductDto product) {
            Product productResult = new Product();
            productResult.Id = product.Id;
            productResult.Name = product.Name;
            productResult.SellingPrice = product.SellingPrice;
            productResult.CostPrice = product.CostPrice;
            return productResult;
        }
    }
}