using AssociationCRMDawanPoe.Entity;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Persistance
{
    public class MenuRepository : AbstractRepository
    {

        public ProductRepository ProductRepository;

        public MenuRepository(string connexionString) : base(connexionString)
        {
            ProductRepository = new ProductRepository(connexionString);
        }

        public Menu GetById(int id)
        {
            Menu Menu = this.EntityManager.Query("Menu").Get<Menu>().First();
            var Products = this.EntityManager.Query("Menu_Product").Where("MenuId", Menu.Id).Get();
            foreach (var item in Products)
            {
                Menu.products.Add(this.ProductRepository.GetById(item.ProductId));
            }
            return Menu;
        }


        public void Create(Menu m)
        {
            int affected = this.EntityManager.Query("Menu").Insert(new
            {
                Name = m.Name
            });
            m.Id = affected;
            foreach (Product product in m.products)
            {
                this.EntityManager.Query("Menu_Product").Insert(new
                {
                    MenuId = m.Id,
                    ProductId = product.Id
                });
            }
        }

        public void Update(Menu m)
        {
            int affected = this.EntityManager.Query("Menu").Where("Id", m.Id).Update(new
            {
                Name = m.Name
            });
             this.EntityManager.Query("Menu_Product").Where("MenuId", m.Id).Delete();
            foreach (Product product in m.products)
            {
                this.EntityManager.Query("Menu_Product").Insert(new
                {
                    MenuId = m.Id,
                    ProductId = product.Id
                });
            }
        }
    }
}
