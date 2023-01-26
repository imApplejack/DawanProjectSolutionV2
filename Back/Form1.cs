using AssociationCRMDawanPoe.Persistance;
using AssociationCRMDawanPoe.Service;
using Back.KpiController;
using Back.ProductController;

namespace Back
{
    public partial class Form1 : Form
    {


        public string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CRM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        IOrderService _orderService;
        IProductService _productService;



        public Form1(string connectionstring)
        {
            _connectionString = connectionstring;
            _orderService = new OrderServiceImpl(new OrderRepository(connectionstring));
            _productService = new ProductServiceImpl(new ProductRepository(connectionstring));
            InitializeComponent();




            //dataGridView1.Data
        }

   



        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            KpiForm form = new KpiForm(_orderService);
            form.Show();

        }



        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produitsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm(_productService);
            form.Show();
        }
    }
}