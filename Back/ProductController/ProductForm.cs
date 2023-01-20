using AssociationCRMDawanPoe.Entity;
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

        public Product tpmProduct = new Product();

        public ProductForm(IProductService productService)
        {
            ProductService = productService;
            InitializeComponent();
            FillDataGridProduct();
        }




        public void FillDataGridProduct()
        {
            ProductDatagrid.DataSource = ProductService.GetAll();
        }

        public void SyncDatagridToInput(int id)
        {
            this.tpmProduct = ProductService.GetById(id);
            idBox.Text = tpmProduct.Id.ToString();
            nameBox.Text = tpmProduct.Name.ToString();
            imgBox.Text = tpmProduct.Image.ToString();
            priceBox.Text = tpmProduct.Price.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (ProductDatagrid.SelectedRows[0].Cells[3].Value != null)
            {
                SyncDatagridToInput((int)ProductDatagrid.SelectedRows[0].Cells[3].Value);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            tpmProduct = new Product();
            idBox.Text = "";
            nameBox.Text = "";
            imgBox.Text = "";
            priceBox.Text = "";
        }


        private void MajButton_Click(object sender, EventArgs e)
        {
            try
            {
                tpmProduct.Price = double.Parse(priceBox.Text);
                tpmProduct.Name = nameBox.Text;
                tpmProduct.Image = imgBox.Text;
                if (tpmProduct.Id != null)
                {
                    ProductService.UpdateProduct(tpmProduct);
                }
                else
                {
                    ProductService.Createproduct(tpmProduct);
                }

                SyncDatagridToInput((int)tpmProduct.Id);
            }
            catch(Exception)
            {

            }

            FillDataGridProduct();
        }

       
    }
}
