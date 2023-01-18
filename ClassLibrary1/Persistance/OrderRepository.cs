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

        public OrderRepository(string connexionString) : base(connexionString)
        { 
        }

        public void Create(Order o)
        {
            int affected = this.EntityManager.Query("Command").Insert(new
            {
               OrderState = o.OrderState,
                OrderName = o.OrderName 
            });
            o.Id = affected;
            
            foreach (Product product in o.Products)
            {
                this.EntityManager.Query("Command_Product").Insert(new
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



        public Menu GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
