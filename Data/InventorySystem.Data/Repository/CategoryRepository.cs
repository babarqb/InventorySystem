using InventorySystem.Data.Model;

namespace InventorySystem.Data.Repository
{
    public class CategoryRepository :Repository<Category>, ICategoryRepository
    {
        public AppDbContext AppDbContext => Context as AppDbContext;
        public CategoryRepository(AppDbContext context): base(context)
        {
            
        }
    }
}