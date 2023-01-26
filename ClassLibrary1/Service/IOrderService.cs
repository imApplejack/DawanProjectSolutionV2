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

        public List<Order> GetAll();
    }
}
