using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Data.Model
{
    public class Product
    {   
        [Key]
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public string ProductModel { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("VendorId")]
        public Vendor Vendor { get; set; }
        public int VendorId { get; set; }
        public decimal ProductPurchasePrice { get; set; }
        public bool ProductIsInStock { get; set; }
        public int ProductStockLevel { get; set; }
        public DateTime ProductPurchaseDate { get; set; }


    }
}