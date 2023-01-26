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

        public OrderForm(IProductService productService)
        {

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
                textBoxTotal.Text = i.ToString();
            }

        }
    }
}
