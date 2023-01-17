using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Persistance.Menu_DAO
{
    public class MenuDAO : IMenuDAO
    {
        private readonly List<Menu> _menus = new();

        public MenuDAO()
        {
            _menus.Add(new Menu("Menu Kebab", new List<Product>{
                new Product{ Id=1,Name="Kebab",Price=5},
                new Product { Id = 2, Name="Frites",Price=3 },
                new Product {Id=3,Name="Eau",Price=1 } }));
            _menus.Add(new Menu("Menu Galette", new List<Product>{
                new Product{ Id=1,Name="Galette",Price=5},
                new Product { Id = 2, Name="Frites",Price=3 },
                new Product {Id=3,Name="Limonade",Price=1 } }));
            _menus.Add(new Menu("Menu Tacos", new List<Product>{
                new Product{ Id=1,Name="Tacos",Price=5},
                new Product { Id = 2, Name="Semoule",Price=3 },
                new Product {Id=3,Name="Cola",Price=1 } }));
        }
        public void Delete(Menu m)
        {
            Menu? found = GetByName(m.Name);
            if (found is not null)
            {
                _menus.Remove(found);
            }
        }

        public List<Menu> GetAll()
        {
            return _menus;
        }

        public Menu? GetByName(string name)
        {
            return _menus.FirstOrDefault(m => m.Name == name);
        }

        public void Insert(Menu m)
        {
            m.Id = _menus.Count >0 ? _menus.Max(m => m.Id)+1 : 1;
            _menus.Add(m);
        }

        public void Update(Menu m)
        {
            Menu? found = GetByName(m.Name);
            if (found is not null)
            {
                _menus[_menus.IndexOf(found)] = m;
            }
        }
    }
}
