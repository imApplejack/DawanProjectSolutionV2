using AssociationCRMDawanPoe.Persistance;
using AssociationCRMDawanPoe.Service;
using Back.KpiController;
using Back.OrderController;
using Back.ProductController;

namespace Back
{
    public partial class Form1 : Form
    {


        public string _connectionString;
        IOrderService _orderService;
        IProductService _productService;
        IMenuService _menuService;



        public Form1(string connectionstring)
        {
            _connectionString = connectionstring;
            _orderService = new OrderServiceImpl(new OrderRepository(connectionstring));
            _productService = new ProductServiceImpl(new ProductRepository(connectionstring));
            _menuService =new MenuServiceImpl(new MenuRepository(connectionstring));
            InitializeComponent();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            KpiForm form = new KpiForm(_orderService);
            form.ShowDialog();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm(_productService, _menuService, _orderService);
            form.ShowDialog();
        }

        private void produitsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm(_productService);
            form.ShowDialog();
        }
    }
}