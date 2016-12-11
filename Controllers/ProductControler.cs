using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using inventory_api.Models;

namespace inventory_api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductRepository productRepository;
        public ProductController(IProductRepository productRepository){
            this.productRepository = productRepository;
        }
        // GET api/product
        [HttpGet]
        public IEnumerable<ProductDto> Get()
        {
           return this.productRepository.GetAll();
        }

        [HttpPost]
        [ProducesResponseTypeAttribute(typeof(ProductDto), 200)]
        public IActionResult Add([FromBody] ProductDto product){
            ProductDto productDto =  this.productRepository.Add(product);
            return new OkObjectResult(productDto);
 
        }
    }
}
