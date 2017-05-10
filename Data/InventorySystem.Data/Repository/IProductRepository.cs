using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using InventorySystem.Data.Model;

namespace InventorySystem.Data.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        decimal GetProductPurchasePriceTotal(int id);
        IEnumerable<Product> FindProductsOutOfStock(Expression<Func<Product>> predicate);
    }
}
