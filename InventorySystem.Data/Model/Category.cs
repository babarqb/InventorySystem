using System.ComponentModel.DataAnnotations;

namespace InventorySystem.DAL.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}