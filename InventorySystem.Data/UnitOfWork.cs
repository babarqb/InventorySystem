using System;
using InventorySystem.DAL.Repository;

namespace InventorySystem.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            Products = new ProductRepository(_context);
            Categories = new CategoryRepository(_context);
            Brands = new BrandRepository(_context);
            Vendors = new VendorRepository(_context);
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IProductRepository Products { get; }
        public ICategoryRepository Categories { get; }
        public IBrandRepository Brands { get; }
        public IVendorRepository Vendors { get; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}