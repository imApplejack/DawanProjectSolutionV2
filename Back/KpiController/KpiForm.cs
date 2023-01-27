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

namespace Back.KpiController
{


    public partial class KpiForm : Form
    {

        IOrderService _orderService;


        public KpiForm(IOrderService orderService)
        {

            _orderService = orderService;

            // OrderDatagrid.DataSource= orderService.


         


           
           // pouet.DataSource = orders;
           // OrderDatagrid.DataSource = orders;

            InitializeComponent();


            OrderDatagrid.DataSource = orderService.GetAll();
        }
    }
}
