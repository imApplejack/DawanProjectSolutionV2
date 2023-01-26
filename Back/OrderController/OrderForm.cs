using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Persistance;
using AssociationCRMDawanPoe.Service;
using System.ComponentModel;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Back.OrderController
{
    public partial class OrderForm : Form
    {
        //public IOrderService orderService;
        //public IMenuService menuService;

        //public List<string> NavigationCategories = new List<string>();

        public List<Product> Products = new List<Product>();
        public List<Menu> Menus = new List<Menu>();
        public Order CurrentOrder = new Order();
        public IOrderService _OrderService;
        

        public OrderForm(IProductService productService, IMenuService menuService, IOrderService orderService)
        {

            Products = productService.GetAll();
            Menus = menuService.GetAll();
            _OrderService = orderService;
           // CurrentOrder = orderService.NewOrder();
            CurrentOrder = new Order();

            InitializeComponent();
            

            #region Initialisation ListViewCategories
            // NavigationCategories = GetAllCategories();
            GetAllCategories();

            //listViewCategories.BindingContext = NavigationCategories;
            #endregion
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            dataGridOrder.DataSource=new List<Product>();
           
            #region Paramètres d'affichage:

            textBoxOrderName.Enabled = false;

            textBoxTotal.Enabled = false;
            textBoxTotal.TextAlign = HorizontalAlignment.Center;
            textBoxOrderName.TextAlign = HorizontalAlignment.Center;

            //DataGrid
            dataGridOrder.Columns["id"].Visible = false;
            dataGridOrder.Columns["Image"].Visible = false;
            dataGridOrder.ReadOnly = true;
            dataGridOrder.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridOrder.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOrder.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOrder.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridOrder.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOrder.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridOrder.ForeColor = Color.Black;
            #endregion
          //  BindWindow();
        }
        private void BindWindow()
        {
            
            
            textBoxOrderName.Text = CurrentOrder.OrderName;
            //textBoxTotal.Text = CurrentOrder.GetPrice().ToString();
            List<Product> p = new List<Product>();
            foreach (Product product in CurrentOrder.Products)
            {
                p.Add(product);
            }
            /*
            foreach (Menu item in CurrentOrder.Menus)
            {
                p.Add(item);
            }*/
            dataGridOrder.DataSource = p;
           // dataGridOrder.Refresh();
        }

        #region
        public void GetAllCategories()
        {
            List<ProductCategory> cat = Enum.GetValues(typeof(ProductCategory)).Cast<ProductCategory>().ToList();
            foreach (var item in cat)
            {
                listBoxCategories.Items.Add(item);
            }
        }

        #endregion

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxProduitMenu.Items.Clear();
            if (listBoxCategories.SelectedItem is not null)
            {
                int i = listBoxCategories.SelectedIndex;
                var selected = Enum.GetValues(typeof(ProductCategory)).Cast<ProductCategory>().ToList()[i];
                
                List<Product> p = Products.Where(x => (x.ProductCategory) == selected).ToList();
                //Affiche les produits dans la liste de sélection.
                foreach (Product item in p)
                {
                    listBoxProduitMenu.Items.Add(item.Name);
                }
            }

        }

        private void listBoxProduitMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = (string)listBoxProduitMenu.SelectedItem;
            Product chosenProduct = Products.Where(x => x.Name == str).FirstOrDefault();
            CurrentOrder.Products.Add(chosenProduct);
            BindWindow();
        }

        private void buttonPayer_Click(object sender, EventArgs e)
        {
            /*
            _OrderService.PayeOrder(CurrentOrder);
            CurrentOrder = _OrderService.NewOrder();*/
            _OrderService.NewOrder(CurrentOrder, OrderState.Payed);
            CurrentOrder= new Order();
            BindWindow();

        }
    }
}
