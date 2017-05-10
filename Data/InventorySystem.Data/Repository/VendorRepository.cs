using InventorySystem.Data.Model;

namespace InventorySystem.Data.Repository
{
    public class VendorRepository :Repository<Vendor>, IVendorRepository
    {
        public AppDbContext AppDbContext => Context as AppDbContext;
        public VendorRepository(AppDbContext context):base(context)
        {
            
        }
    }
}