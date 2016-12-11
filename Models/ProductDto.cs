using System;

namespace inventory_api.Models
{
    public class ProductDto{
        public Guid Id {get;set;}
        public string Name {get;set;}
        public string Image {get;set;}
        public double CostPrice {get;set;}
        public double SellingPrice {get;set;}
    }
}