using AssociationCRMDawanPoe.Persistance;
using AssociationCRMDawanPoe.Service;
using Back.ProductController;

namespace Back
{
    public partial class Form1 : Form
    {


        public string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CRM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        IOrderService _orderService;
        IProductService productService;



        public Form1(string connectionstring)
        {
            _connectionString = connectionstring;
            _orderService = new OrderServiceImpl(new OrderRepository(connectionstring));
            productService = new ProductServiceImpl(new ProductRepository(connectionstring));
            InitializeComponent();




            //dataGridView1.Data
        }

   



        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }



        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produitsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm(productService);
            form.Show();
        }
    }
}