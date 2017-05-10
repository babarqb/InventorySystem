using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using InventorySystem.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.DAL.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        decimal GetProductPurchasePriceTotal(int id);
        IEnumerable<Product> FindProductsOutOfStock(Expression<Func<Product>> predicate);
    }
}
