using AssociationCRMDawanPoe.Entity;
using ProjectAPI.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Service
{
    public class MenuServiceImpl : IMenuService
    {

        IMenuRepository MenuRepository;

        public MenuServiceImpl(IMenuRepository menuRepository)
        {
            MenuRepository = menuRepository;
        }
        
        public List<Menu> GetAll()
        {
            return MenuRepository.GetAll();
        }

        public Menu GetById(int id)
        {
            return MenuRepository.GetById(id);
        }
    }
}
