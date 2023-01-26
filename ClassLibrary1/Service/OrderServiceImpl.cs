using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Persistance;
using ProjectAPI.Persistance;
using SqlKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Service
{
    public class OrderServiceImpl : IOrderService
    {

        public IOrderRepository OrderRepository { get; set; }

        public OrderServiceImpl(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }

        public Order CallOrder(string ordername)
        {
            throw new NotImplementedException();
        }

        public Order NewOrder(Order order)
        {
            order.OrderName = "mon order nul " + DateTime.Now;
            OrderRepository.Create(order);
            return order;
        }


        public List<Order> GetAll()
        {

            return OrderRepository.GetAll();
        }

    }
}
