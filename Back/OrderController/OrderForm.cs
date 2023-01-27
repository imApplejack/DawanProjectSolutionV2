using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Service;
using ProjectAPI.ItemDTO;
using System.Data;

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
        public List<ItemDTO> ItemDTOs;


        public OrderForm(IProductService productService, IMenuService menuService, IOrderService orderService)
        {


            Products = productService.GetAll();
            Menus = menuService.GetAll();
            _OrderService = orderService;
            CurrentOrder = new Order();
            ItemDTOs = new List<ItemDTO>();

            InitializeComponent();


            #region Initialisation ListViewCategories
            GetAllCategories();

            #endregion
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            dataGridOrder.DataSource = new List<ItemDTO>();

            #region Paramètres d'affichage:

            textBoxOrderName.Enabled = false;

            textBoxTotal.Enabled = false;
            textBoxTotal.TextAlign = HorizontalAlignment.Center;
            textBoxOrderName.TextAlign = HorizontalAlignment.Center;

            //DataGrid
            dataGridOrder.Columns["id"].Visible = false;
            //dataGridOrder.Columns["Image"].Visible = false;
            dataGridOrder.Columns["Type"].Visible = false;
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
            List<ItemDTO> p = new List<ItemDTO>();
            foreach (var product in ItemDTOs)
            {
                p.Add(product);
            }
            
            dataGridOrder.DataSource = p;
        }

        #region
        public void GetAllCategories()
        {
            List<ProductCategory> cat = Enum.GetValues(typeof(ProductCategory)).Cast<ProductCategory>().ToList();
            foreach (var item in cat)
            {
                listBoxCategories.Items.Add(item);
            }
            listBoxCategories.Items.Add("Menus");

        }

        #endregion

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxProduitMenu.Items.Clear();
            if (listBoxCategories.SelectedItem is not null)
            {
                if (listBoxCategories.SelectedItem.ToString() == "Menus")
                {
                    foreach (var menu in Menus)
                    {

                        listBoxProduitMenu.Items.Add(menu.Name);
                    }
                }
                else
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

        }

        private void listBoxProduitMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = (string)listBoxProduitMenu.SelectedItem;
            if (listBoxCategories.SelectedItem.ToString() == "Menus")
            {
                Menu chosenmenu = Menus.Where(x => x.Name == str).FirstOrDefault();
                CurrentOrder.Menus.Add(chosenmenu);
                ItemDTOs.Add(new ItemDTO(chosenmenu));
            }
            else
            {
                Product chosenProduct = Products.Where(x => x.Name == str).FirstOrDefault();
                CurrentOrder.Products.Add(chosenProduct);
                ItemDTOs.Add(new ItemDTO(chosenProduct));

            }
            BindWindow();
        }

        private void buttonPayer_Click(object sender, EventArgs e)
        {
            _OrderService.NewOrder(CurrentOrder, OrderState.Payed);
            BindWindow();
            CurrentOrder = new Order();

        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            int? selected = (dataGridOrder.SelectedRows[0]).Index;
            if (selected is null)
            {
                MessageBox.Show("Veuillez sélectionner un article");
            }
            else
            {
                ItemDTOs.RemoveAt(selected.Value);
                CurrentOrder.Products.Clear();
                CurrentOrder.Products.AddRange(ItemDTO.GetProducts(ItemDTOs));
                CurrentOrder.Menus.Clear();
                CurrentOrder.Menus.AddRange(ItemDTO.GetMenus(ItemDTOs));
                
                BindWindow();


            }
        }
    }
}
