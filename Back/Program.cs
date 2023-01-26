using AssociationCRMDawanPoe.Persistance;
using AssociationCRMDawanPoe.Service;
using Back.OrderController;
using Back.ProductController;
using System.Configuration;
using System.Drawing.Text;

namespace Back
{
    internal static class Program
    {


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string CS = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CRM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            IProductService productService = new ProductServiceImpl(new ProductRepository(CS));
            IMenuService menuService = new MenuServiceImpl(new MenuRepository(CS));
            IOrderService orderService = new OrderServiceImpl(new OrderRepository(CS));


        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new ProductForm(productService));
            Application.Run(new OrderForm(productService, menuService, orderService));
        }
    }
}