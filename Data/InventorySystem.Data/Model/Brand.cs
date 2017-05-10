using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Data.Model
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }

        public string BrandName { get; set; }
//        [ForeignKey("CategoryId")]
//        public Category Category { get; set; }
//        public int CategoryId { get; set; }
    }
}