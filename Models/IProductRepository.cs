using System.Collections.Generic;

namespace inventory_api.Models{
    public interface IProductRepository{
        IEnumerable<ProductDto> GetAll();
        ProductDto Add(ProductDto productDto);
    }
}