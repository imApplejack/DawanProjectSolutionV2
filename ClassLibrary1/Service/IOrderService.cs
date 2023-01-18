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
        public Order NewOrder(Order order);
        public Order CallOrder(string ordername);
    }
}
