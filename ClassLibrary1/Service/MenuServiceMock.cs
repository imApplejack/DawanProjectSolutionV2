using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Service
{
    public class MenuServiceMock : IMenuService
    {


        public MenuServiceMock()
        {
        }

        public void Add(Menu menu)
        {
            throw new NotImplementedException();
        }

        public void Delete(string name)
        {
            throw new NotImplementedException();
        }


        // new Product { Name = "titi", Price = 25.0 }, new Product { Name = "titi", Price = 2.0 }
        public List<Menu> GetAll()
        {
            return new List<Menu> { new Menu() { Name = "menu pouet", products = new List<Product> {
               new Product { Name = "toto", Price = 25.0 }, new Product { Name = "titi", Price = 10.0 }

           }
           } ,

           new Menu() { Name = "menu pouit", products = new List<Product> {
               new Product { Name = "toto", Price = 2.0 }, new Product { Name = "titi", Price = 10.0 }

           }
           }
            };



        }

        public Menu GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Menu GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Menu menu)
        {
            throw new NotImplementedException();
        }
    }
    
}
