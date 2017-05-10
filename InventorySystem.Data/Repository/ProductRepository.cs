using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using InventorySystem.DAL.Model;

namespace InventorySystem.DAL.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public decimal GetProductPurchasePriceTotal(int id)
        {
            decimal total = AppDbContext.Products.Where(p => p.ProductId == id).Sum(c => c.ProductPurchasePrice);
            return total;
        }

        public IEnumerable<Product> FindProductsOutOfStock(Expression<Func<Product>> predicate)
        {
            return AppDbContext.Products.Where(p => p.ProductStockLevel == 0).ToList();
        }

        public AppDbContext AppDbContext => Context as AppDbContext;
    }
}