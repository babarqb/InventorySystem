using System;
using InventorySystem.DAL.Repository;

namespace InventorySystem.DAL
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
