using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inventory_api.Models{
    [Table("Product")]
    public class Product{
        [Required]        
        [Key]
        public Guid Id {get;set;}
        [Required]
        public string Name {get;set;}
        public string Image {get;set;}
        [Required]        
        [DataType(DataType.Currency)]
        public double CostPrice {get;set;}
        [Required]       
        [DataType(DataType.Currency)]
        public double SellingPrice {get;set;}            
    }
}