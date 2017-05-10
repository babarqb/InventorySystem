using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using InventorySystem.Data;
using InventorySystem.Data.Model;
using MahApps.Metro.Controls;

namespace InventorySystem.Ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            AddProduct();
        }

        private static void AddProduct()
        {
            using (var db = new UnitOfWork(new AppDbContext()))
            {
                //var products = db.Products.GetAllProducts();
                var product = db.Products.Get(1);

//                var product = new Product
//                {
//                    
//                    ProductType = "CellPhones",
//                    ProductIsInStock = true,
//                    ProductModel = "SGH-J300F/DS",
//                    ProductPurchaseDate = DateTime.Today,
//                    ProductPurchasePrice = 12500,
//                    ProductStockLevel = 0,
//                    BrandId = 2,
//                    CategoryId = 1,
//                    VendorId = 1
//                };
//                db.Products.Add(product);
//                db.Complete();
                //var amount = db.Products.GetProductPurchasePriceTotal();
                //var outOfStockProduct = db.Products.FindProductsOutOfStock(p => p.ProductStockLevel == 0);
//                foreach (var product in outOfStockProduct)
//                {
//                    var brand = product.Brand.BrandName;
//                    var brandId = product.Brand.BrandId;
//                    var bId = product.BrandId;
//                }
            }
        }
    }
}
