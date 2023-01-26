using AssociationCRMDawanPoe.Entity;
using ProjectAPI.Persistance;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Persistance
{
    public class OrderRepository : AbstractRepository, IOrderRepository
    {

        public ProductRepository ProductRepository;
        public MenuRepository MenuRepository;

        public OrderRepository(string connexionString) : base(connexionString)
        {

            ProductRepository = new ProductRepository(connexionString);
            MenuRepository = new MenuRepository(connexionString);
        }


        private void HydrateMenuChilds(Order Order)
        {
            var Menus = this.EntityManager.Query("Command_Menu").Where("CommandId", Order.Id).Get();
            foreach (var item in Menus)
            {
                Order.Menus.Add(this.MenuRepository.GetById(item.MenuId));
            }
        }

        private void HydrateProductChilds(Order Order)
        {
            var Products = this.EntityManager.Query("Command_Product").Where("CommandId", Order.Id).Get();
            foreach (var item in Products)
            {
                Order.Products.Add(this.ProductRepository.GetById(item.ProductId));
            }
        }

        public void Create(Order o)
        {
            int affected = this.EntityManager.Query("Command").InsertGetId<int>(new
            {
               OrderState = o.OrderState,
                OrderName = o.OrderName 
            });
            o.Id = affected;
            
            foreach (Product product in o.Products)
            {
               var retour =  this.EntityManager.Query("Command_Product").Insert(new
                {
                    CommandId = o.Id,
                    ProductId = product.Id
                });
            }
            foreach (Menu menu in o.Menus)
            {
                this.EntityManager.Query("Command_Menu").Insert(new
                {
                    CommandId = o.Id,
                    MenuId = menu.Id
                });
            }
        }

        public List<Order> GetAll()
        {
            IEnumerable<Order> Orders = this.EntityManager.Query("Command").Get<Order>();
            foreach (Order order in Orders)
            {
                HydrateMenuChilds(order);
                HydrateProductChilds(order);
            }
            return Orders.ToList();

        }



        public Menu GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
