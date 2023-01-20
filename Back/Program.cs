using AssociationCRMDawanPoe.Persistance;
using AssociationCRMDawanPoe.Service;
using Back.Product;
using System.Configuration;

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

            IProductService productService = new ProductServiceImpl(new ProductRepository(ConfigurationManager.ConnectionStrings["chConnexion"].ConnectionString));


        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ProductForm(productService));
        }
    }
}