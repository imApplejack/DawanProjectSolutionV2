using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI.Persistance
{
    public interface IMenuRepository
    {
        public Menu GetById(int id);

        public List<Menu> GetAll();

    }
}
