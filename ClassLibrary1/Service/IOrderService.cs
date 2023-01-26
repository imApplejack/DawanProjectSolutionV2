using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Service
{
    public interface IOrderService
    {
        public Order NewOrder(Order order, OrderState orderstate = OrderState.Pending);
        public List<Order> CallOrder(string ordername = null);
        //Demande au repo de fournir une nouvelle commande
       // public Order NewOrder();

        //
       // public void PayeOrder(Order o);
        //public void AbordOrder(Order o);
    }
}
