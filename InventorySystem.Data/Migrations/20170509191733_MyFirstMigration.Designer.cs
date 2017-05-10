using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using InventorySystem.DAL;

namespace InventorySystem.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170509191733_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventorySystem.DAL.Model.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandName");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("InventorySystem.DAL.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("InventorySystem.DAL.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BrandId");

                    b.Property<int?>("CategoryId");

                    b.Property<bool>("ProductIsInStock");

                    b.Property<string>("ProductModel");

                    b.Property<decimal>("ProductPurchasePrice");

                    b.Property<int>("ProductStockLevel");

                    b.Property<string>("ProductType");

                    b.Property<int?>("VendorId");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("VendorId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InventorySystem.DAL.Model.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("VendorCity");

                    b.Property<string>("VendorContact");

                    b.Property<string>("VendorName");

                    b.HasKey("VendorId");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("InventorySystem.DAL.Model.Product", b =>
                {
                    b.HasOne("InventorySystem.DAL.Model.Brand", "ProductBrand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("InventorySystem.DAL.Model.Category", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("InventorySystem.DAL.Model.Vendor", "ProductVendor")
                        .WithMany()
                        .HasForeignKey("VendorId");
                });
        }
    }
}
