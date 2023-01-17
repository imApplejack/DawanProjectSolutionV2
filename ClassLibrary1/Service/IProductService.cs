using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Service
{
    public interface IProductService
    {

        List<Product> GetAll();

        void UpdateProduct(Product p);

        void Createproduct(Product p);

        void RemoveProductById(int id);


        /*
        List<Product> FindByName(string name);
        List<Product> FindByCategory(string Category);
    

        public List<Product> getAllProduct();
        public List<string> GetAllCategory();

        */
    }
}
