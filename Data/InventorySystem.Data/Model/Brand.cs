using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Data.Model
{
    public class Brand
    {
        public Brand()
        {
            Products = new List<Product>();
        }
        [Key]
        public int BrandId { get; set; }

        public string BrandName
        {
            get; set; 
            
        }
        public ICollection<Product> Products { get; set; }
    }
}