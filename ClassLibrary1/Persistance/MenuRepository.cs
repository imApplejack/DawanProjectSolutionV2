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
    public class MenuRepository : AbstractRepository, IMenuRepository
    {

        public ProductRepository ProductRepository;

        public MenuRepository(string connexionString) : base(connexionString)
        {
            ProductRepository = new ProductRepository(connexionString);
        }


        private void HydrateMenuChilds(Menu Menu)
        {
            var Products = this.EntityManager.Query("Menu_Product").Where("MenuId", Menu.Id).Get();
            foreach (var item in Products)
            {
                Menu.products.Add(this.ProductRepository.GetById(item.ProductId));
            }
        }


        public Menu GetById(int id)
        {
            Menu Menu = this.EntityManager.Query("Menu").Where("Id", id).Get<Menu>().First();
            HydrateMenuChilds(Menu);
            return Menu;
        }


        public List<Menu> GetAll()
        {
            IEnumerable<Menu> Menus = this.EntityManager.Query("Menu").Get<Menu>();
            foreach (Menu menu in Menus)
            {
                HydrateMenuChilds(menu); 
            }
            return Menus.ToList();
        }



        public void Create(Menu m)
        {
            int affected = this.EntityManager.Query("Menu").InsertGetId<int>(new
            {
                Name = m.Name,Image = m.Image
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
                Name = m.Name,Image = m.Image
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
