using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.DAL.Model
{
    public class Product
    {   
        [Key]
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public string ProductModel { get; set; }
        [ForeignKey("BrandId")]
        public int ProductBrand { get; set; }
        [ForeignKey("CategoryId")]
        public int ProductCategory { get; set; }
        [ForeignKey("VendorId")]
        public int ProductVendor { get; set; }
        public decimal ProductPurchasePrice { get; set; }
        public bool ProductIsInStock { get; set; }
        public int ProductStockLevel { get; set; }

    }
}