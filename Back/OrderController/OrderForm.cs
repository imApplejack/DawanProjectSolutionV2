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

namespace Back.OrderController
{
    public partial class OrderForm : Form
    {
        //public IOrderService orderService;
        //public IMenuService menuService;
        //public IProductService productService;

        public List<string> NavigationCategories = new List<string>();

        public List<Product> products = new List<Product>();
        public List<Menu> menus = new List<Menu>();

        public OrderForm()
        {
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
            NavigationCategories = new List<string>();

            #endregion
        }
    }
}
