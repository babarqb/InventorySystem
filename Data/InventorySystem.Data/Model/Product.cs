using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Data.Model
{
    public class Product
    {
        
        [Key]
        public  int ProductId { get; set; }
        public  string ProductType { get; set; }
        public  string ProductModel { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; } = new Brand();
        public  int BrandId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } = new Category();
        [ForeignKey("VendorId")]
        public virtual Vendor Vendor { get; set; } = new Vendor();
        public  int VendorId { get; set; }
        public  decimal ProductPurchasePrice { get; set; }
        public  bool ProductIsInStock { get; set; }
        public  int ProductStockLevel { get; set; }
        public virtual DateTime ProductPurchaseDate { get; set; }


    }
}