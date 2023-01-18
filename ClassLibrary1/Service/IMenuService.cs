using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Service
{
    public interface IMenuService
    {
        public List<Menu> GetAll();

        public Menu GetById(int id);

    }
}
