using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Data.Model
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }

        public string VendorName { get; set; }
        public string VendorCity { get; set; }
        public string VendorContact { get; set; }
    }
}