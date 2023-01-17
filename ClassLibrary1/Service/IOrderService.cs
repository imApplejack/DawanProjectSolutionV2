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
        public Order NewOrder();
        public Order CallOrder(string ordername);
    }
}
