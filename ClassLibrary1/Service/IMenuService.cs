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
        List<Menu> GetAll();

        Menu GetByName(string name);

        void Add(Menu menu);

        void Delete(string name);

        void Update(Menu menu);


    }
}
