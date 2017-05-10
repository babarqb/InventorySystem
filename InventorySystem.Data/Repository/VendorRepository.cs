using System;
using InventorySystem.DAL.Model;

namespace InventorySystem.DAL.Repository
{
    public class VendorRepository :Repository<Vendor>, IVendorRepository
    {
        public AppDbContext AppDbContext => Context as AppDbContext;
        public VendorRepository(AppDbContext context):base(context)
        {
            
        }
    }
}