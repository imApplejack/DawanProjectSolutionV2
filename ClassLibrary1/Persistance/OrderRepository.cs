using AssociationCRMDawanPoe.Entity;
using ProjectAPI.Persistance;
using SqlKata;
using SqlKata.Execution;
using System.Collections;
using System.Data;

namespace AssociationCRMDawanPoe.Persistance
{
    public class OrderRepository : AbstractRepository, IOrderRepository
    {
        //
        public ProductRepository _productRepository;// Pas nécessaire car le repoMenu appelle lui même le repo des produits?
        public MenuRepository _menuRepository;
        //Constructeur
        public OrderRepository(string connexionString) : base(connexionString)
        {
            _menuRepository = new MenuRepository(connexionString);
            _productRepository = new ProductRepository(connexionString);
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

        //COMMENT: ça me semble vraiment étrange comme manière de faire
        public Order Create()
        {
            //Je demande à la base de me donner un ID
            int affected = this.EntityManager.Query("Command").InsertGetId<int>(new
            {
            });
            //Je créé une commande avec cet ID, avec le status par défaut "Pending" et le nom de commande issu d'un formatage spécifique...Je trouve ça très étrange, revoir model objet?
            Order order = new Order()
            {
                Id = affected,
                OrderState = OrderState.Pending,
                OrderName = DateTime.Now.ToString() + "#" + $"{1000 + affected}"
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
            //Mise à jour de la table commande
            //TODO dans la couche service, tester le status de la commande

            //On met à jour la table "Commande" s'il y a eu une modification de status
            EntityManager.Query("Command").Where("Id", o.Id).Update(o);
            //Pour chaque produit
            //Passer par un dictionnaire intermédiaire peut réduire le nombre de requêtes.
            /*
             Dictionary<Product, int> dico = new();
             foreach (Product p in o.Products)
             {
                 if (!dico.ContainsKey(p))
                 {
                     dico.Add(p, o.Products.Where(w => w.Id == p.Id).Count());
                 }
             }
             foreach (var K in dico)
             {


                 int ProductInBDD = EntityManager.Query("Command_Product").Where("CommandId", o.OrderName).Where("ProductId", K.Key.Id).Get().Count();
                 if (K.Value == 0)
                 {
                     continue;
                 }
                 else if (K.Value > ProductInBDD)
                 {
                     for (int i = ProductInBDD; i < K.Value; i++)
                     {
                         EntityManager.Query("Command_Product").Insert(new
                         {
                             CommandID = o.Id,
                             ProductId = K.Key.Id,
                         });
                     }
                 }
             }

 */
            foreach (Product item in o.Products)
            {
                //comparaison entre le nombre de produits présents dans la commande 'o' et dans la commande stockée en base.
                int nombreDansCommande = o.Products.Where(x => x.Id == item.Id).Count();
                int nombreBDD = EntityManager.Query("Command_Product").Where("CommandId", o.OrderName).Where("ProductId", item.Id).Get().Count();

                if (nombreBDD == nombreDansCommande)
                {
                    continue;
                }
                else if (nombreDansCommande > nombreBDD)
                {
                    EntityManager.Query("Command_Product").Insert(new
                    {
                        CommandID = o.Id,
                        ProductId = item.Id,
                    });
                }
                else
                {
                    //TOFIX Manque-t'il un First() ??? 
                    EntityManager.Query("Command_Product").Where("CommandID", o.OrderName).Where("ProductId", item.Id).Delete();

                }

            }

        }
        /* Facto
        private void AddItem<T>(T obj, Order o) where T : AbstractEntity
        {
            string nomDeTable;
            string cibleId;
            ICollection collection;
            Type type;
            Column col = new();
            if (obj.GetType() == typeof(Product))
            {
                nomDeTable = "Command_Product";
                cibleId = "ProductId";
                collection = o.Products;
                type = typeof(Product);
                col.Name = "ProductId";
            }
            else // if (obj.GetType()==typeof(Menu))
            {
                nomDeTable = "Command_Menu";
                cibleId = "MenuId";
                collection = o.Menus;
                type = typeof(Menu);
                col.Name = "MenuId";
            }
            EntityManager.Query("Command_Product").Insert(new
            {
                CommandID = o.Id,
                Column = obj.Id,
            });

        }*/

    }
}
