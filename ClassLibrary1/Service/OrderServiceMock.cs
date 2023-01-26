using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Service
{
    public class OrderServiceMock : IOrderService
    {
        public Order CallOrder(string ordername)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order NewOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
