using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Entity
{

    public enum ProductCategory {
        Boisson =1,
        Plat=2,
        Accompagnement=3,
        Other=4
    }

    public class Product : AbstractEntity
    {
        public string Name { get; set; } = String.Empty;
        public double Price { get; set; } = 0;

        public string Image { get; set; } = " https://www.maisonreignier.com/wp-content/uploads/2020/08/coca-light-canette-33cl.png";

        public ProductCategory ProductCategory = ProductCategory.Other;

        public double GetPrice()
        {
            return Price;
        }
    }
}
