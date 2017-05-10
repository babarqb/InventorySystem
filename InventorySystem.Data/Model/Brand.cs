using System.ComponentModel.DataAnnotations;

namespace InventorySystem.DAL.Model
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }

        public string BrandName { get; set; }
    }
}