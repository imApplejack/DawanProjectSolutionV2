using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Persistance.Menu_DAO
{
    public interface IMenuDAO
    {
        void Insert(Menu m);

        List<Menu> GetAll();

        Menu GetByName(string name);

        void Update(Menu m);

        void Delete(Menu m);
    }
}
