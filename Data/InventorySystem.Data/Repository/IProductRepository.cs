using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using InventorySystem.Data.Model;

namespace InventorySystem.Data.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        decimal GetProductPurchasePriceTotal();
        IEnumerable<Product> FindProductsOutOfStock(Expression<Func<Product,bool>> predicate);
        IEnumerable<Product> GetAllProducts();
    }
}
