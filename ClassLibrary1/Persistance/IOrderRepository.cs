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
        public Menu GetByName(string name);

        public void Create(Order o);

        public List<Order> GetAll();

    }
}
