using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI.Persistance
{
    public interface IProductRepository
    {
        public Product GetById(int id);

        public void Create(Product p);

        public void Update(Product p);

        public void RemoveById(int id);

        public List<Product> GetAll();

    }
}
