using AssociationCRMDawanPoe.Entity;
using ProjectAPI.Persistance;
using SqlKata;
using SqlKata.Execution;
using System.Collections;
using System.ComponentModel.Design;
using System.Data;

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
            int affected = EntityManager.Query("Command").InsertGetId<int>(new
            {
                OrderState = o.OrderState,
                OrderName = o.OrderName
            });
            o.Id = affected;

            foreach (Product product in o.Products)
            {
                var retour = EntityManager.Query("Command_Product").Insert(new
                {
                    CommandId = o.Id,
                    ProductId = product.Id
                });
            }
            foreach (Menu menu in o.Menus)
            {
                EntityManager.Query("Command_Menu").Insert(new
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

        public Order Create()
        {
            //Je demande à la base de me donner un ID
            int affected = this.EntityManager.Query("Command").InsertGetId<int>(new
            {
                OrderName = DateTime.Now.ToString() + "#" 
            });
            //Je créé une commande avec cet ID, avec le status par défaut "Pending" et le nom de commande issu d'un formatage spécifique...Je trouve ça très étrange, revoir model objet?
            Order order = new Order()
            {
                Id = affected,
                OrderName = DateTime.Now.ToString() + "#" + $"{ 1000+ affected}"
            };
            //TODO: Voir comment créer un OrderName autogénéré.
            //Je mets à jour le nom par défaut.
            EntityManager.Query("Command").Where("Id", affected).Update(new
            {
                OrderName = order.OrderName
            });
            return order;

        }
        public List<Order> GetAll()
        {
            return EntityManager.Query("Command").Get<Order>().ToList();
        }
        public Order GetById(int id)
        {
            return EntityManager.Query("Command").Where("Id", id).First();
        }
        public List<Order> GetByName(string name)
        {
            return EntityManager.Query("Command").WhereContains("OrderName", name).Get<Order>().ToList();
        }

        //TODO: revoir la methode
        public void Update(Order o)
        {            
            EntityManager.Query("Command").Where("Id", o.Id).Update(new
            {
                OrderState = o.OrderState
            });
            //Supprime les tables de jointure
            EntityManager.Query("Command_Product").Where("CommandId", o.Id).Delete();
            EntityManager.Query("Command_Menu").Where("CommandId", o.Id).Delete();
            //Recréé les produits/Menus           
            foreach (Product item in o.Products)
            {
                EntityManager.Query("Command_Product").Insert(new
                {
                    CommandID = o.Id,
                    ProductID= item.Id
                }) ;
            }
            foreach (Menu item in o.Menus)
            {
                EntityManager.Query("Command_Menu").Insert(new
                {
                    CommandID = o.Id,
                    MenuID = item.Id
                });
            }
        }      
    }
}
