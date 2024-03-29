﻿using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Persistance;
using ProjectAPI.Persistance;
using SqlKata;
using System;
using System.Collections;
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

        public List<Order> CallOrder(string ordername = null)
        {
            if (ordername == null)
            {
               return OrderRepository.GetAll();
            }
            else
            {
                return OrderRepository.GetByName(ordername);
            }
        }

        public Order NewOrder(Order order, OrderState orderstate = OrderState.Pending)
        {
            order.OrderName = DateTime.Now.ToString();
            order.OrderState = orderstate;
            OrderRepository.Create(order);
            return order;
        }
        

             

        



        //Tests
        public void methodedetest()
        {

            Product p = new Product();
            Menu menu = new Menu();
            Order order = new Order();

            List<AbstractEntity> list = new();
            list.Add(p);
            list.Add(menu);
            list.Add(order); //Attention, comportement non souhaité!

            list.Where(x => x.GetType() == typeof(Product)).ToList();
            //WAOUW!
        }


        public List<Order> GetAll()
        {

            return OrderRepository.GetAll();
        }

    }
}
