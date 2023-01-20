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

namespace Back.Product
{
    public partial class ProductForm : Form
    {

        public IProductService ProductService;
        public ProductForm(IProductService productService)
        {

            ProductService = productService;

            InitializeComponent();
        }
    }
}
