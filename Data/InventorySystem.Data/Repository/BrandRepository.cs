using InventorySystem.Data.Model;

namespace InventorySystem.Data.Repository
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public AppDbContext AppDbContext => Context as AppDbContext;
        public BrandRepository(AppDbContext context):base(context)
        {
            
        }
    }
}