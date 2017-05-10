using System;
using InventorySystem.DAL.Model;

namespace InventorySystem.DAL.Repository
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public AppDbContext AppDbContext => Context as AppDbContext;
        public BrandRepository(AppDbContext context):base(context)
        {
            
        }
    }
}