using System;
using InventorySystem.Data.Repository;

namespace InventorySystem.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        IBrandRepository Brands { get; }
        IVendorRepository Vendors { get; }
        int Complete();
    }
}
