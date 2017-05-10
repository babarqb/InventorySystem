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
                var product = new Product
                {
                    ProductId = 1,
                    ProductType = "CellPhones",
                    ProductIsInStock = true,
                    ProductModel = "SGH-J500F/DS",
                    ProductPurchaseDate = DateTime.Today,
                    ProductPurchasePrice = 14500,
                    ProductStockLevel = 2,
                    BrandId = 2,
                    CategoryId = 1,
                    VendorId = 1
                };
                db.Products.Add(product);
                db.Complete();
            }
        }
    }
}
