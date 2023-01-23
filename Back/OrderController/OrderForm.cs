using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Persistance;
using AssociationCRMDawanPoe.Service;
using System.Data;

namespace Back.OrderController
{
    public partial class OrderForm : Form
    {
        //public IOrderService orderService;
        //public IMenuService menuService;
        public IProductService productService;

        //public List<string> NavigationCategories = new List<string>();

        public List<Product> Products = new List<Product>();
        public List<Menu> Menus = new List<Menu>();

        public OrderForm()
        {
            productService = new ProductServiceImpl(new ProductRepository("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CRM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

            Products = productService.GetAll();


            InitializeComponent();
            #region Paramètres d'affichage:

            textBoxOrderName.Enabled = false;
            textBoxTotal.Enabled = false;
            textBoxTotal.TextAlign = HorizontalAlignment.Center;
            textBoxOrderName.TextAlign = HorizontalAlignment.Center;

            //DataGrid
            /*
            dataGridOrder.Columns["id"].Visible = false;
            dataGridOrder.ReadOnly = true;
            dataGridOrder.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridOrder.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOrder.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOrder.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridOrder.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOrder.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;*/
            #endregion

            #region Initialisation ListViewCategories
            // NavigationCategories = GetAllCategories();
            GetAllCategories();

            //listViewCategories.BindingContext = NavigationCategories;
            #endregion
        }

        #region
        public void GetAllCategories()
        {
            //List<string> categories = new List<string>();
            //Product p = new();
            var cat = Enum.GetValues(typeof(ProductCategory)).Cast<ProductCategory>().ToList();
            foreach (var item in cat)
            {
                listBoxCategories.Items.Add(item.ToString());
            }

            // return categories;
        }



        #endregion

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxProduitMenu.Items.Clear();
            if (listBoxCategories.SelectedItem is not null)
            {
                int i = listBoxCategories.SelectedIndex;
                textBoxTotal.Text = i.ToString();
                
               //TODO Null exception si pas de produit dans la catégorie other.

                List<Product> p = Products.Where(x => x.ProductCategory.ToString() == listBoxCategories.Items[i+1].ToString()).ToList();

                foreach (Product item in p)
                {
                    listBoxProduitMenu.Items.Add(item.Name);
                }
            }
        }
    }
}
