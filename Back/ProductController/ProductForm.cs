using AssociationCRMDawanPoe.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Back.ProductController
{
    public partial class ProductForm : Form
    {

        public IProductService ProductService;

        //public Product tpmProduct = new Product();

        public ProductForm(IProductService productService)
        {
            ProductService = productService;
            InitializeComponent();
            FillDataGridProduct();
        }




        void FillDataGridProduct()
        {
            ProductDatagrid.DataSource = ProductService.GetAll();
        }

        void SyncMenuToInput()
        {
            
            
              //ProductDatagrid.SelectedRows[0].Cells[3].Value
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {

            // ProductDatagrid.SelectedRows[0].Cells[3].Value;


            Console.WriteLine();
        }

  
    }
}
