using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI.Persistance
{
    public interface IOrderRepository
    {
        //@Eric, pourquoi?
        //public Menu GetByName(string name);


        //Depuis la fenêtre de commande, je dois:
        //Demander une nouvelle commande
        public Order Create();

        //Récupérer une commande
        public Order GetById(int id);
        public List<Order> GetByName(string name);
        public List<Order> GetAll();
        //Mettre à jour une commande en fonction de son status
        public void Update(Order o);


        
        public void Create(Order o);
        //Non nécessaire
        //public void Delete(Order o);

    }
}
