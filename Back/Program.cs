using AssociationCRMDawanPoe.Persistance;
using AssociationCRMDawanPoe.Service;
using Back.ProductController;
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


            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CRM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            //IProductService productService = new ProductServiceImpl(new ProductRepository(connectionString));



        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(connectionString));
        }
    }
}