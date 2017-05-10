using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using InventorySystem.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public decimal GetProductPurchasePriceTotal()
        {
            decimal total = AppDbContext.Products.Sum(p => p.ProductPurchasePrice);
            return total;
        }

        public IEnumerable<Product> FindProductsOutOfStock(Expression<Func<Product,bool>> predicate)
        {
            return AppDbContext.Products.Where(p => p.ProductStockLevel == 0).ToList();
        }

        public AppDbContext AppDbContext => Context as AppDbContext;

        public IEnumerable<Product> GetAllProducts()
        {
            return AppDbContext.Products
                .Include(nameof(Category))
                .Include(nameof(Vendor))
                .Include(nameof(Brand)).ToList();
        }
    }
}