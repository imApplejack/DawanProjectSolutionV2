using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Persistance.Menu_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Service
{
    public class MenuServiceImpl : IMenuService
    {
        private readonly IMenuDAO _dao;

        public MenuServiceImpl(IMenuDAO dao)
        {
            _dao = dao;
        }

        public void Add(Menu menu)
        {
            _dao.Insert(menu);
        }

        public void Delete(string name)
        {
            _dao.Delete(GetByName(name));
        }

        public List<Menu> GetAll()
        {
            return _dao.GetAll();
        }

        public Menu GetByName(string name)
        {
            return _dao.GetByName(name);
        }

        public void Update(Menu menu)
        {
            _dao.Update(menu);
        }
    }
}
