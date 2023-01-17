using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Entity
{

    public enum ProductCategory {
        Boisson,
        Plat,
        Accompagnement,
        Other
    }

    public class Product : AbstractEntity
    {
        public string Name { get; set; } = String.Empty;
        public double Price { get; set; } = 0;

        public ProductCategory ProductCategory = ProductCategory.Other;
    }
}
