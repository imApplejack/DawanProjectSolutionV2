using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Entity
{
    public class Menu : AbstractEntity
    {

        public string Name { set; get; } = String.Empty;

        public List<Product> products = new List<Product>();

        public Menu() { }
        public Menu(string name, List<Product> products)
        {
            Name = name;
            this.products = products;
        }
    }
}
