using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Entity
{

    public enum OrderState
    {
        Cancelled,
        Pending,
        Payed,
        Terminated
    }
    public class Order : AbstractEntity
    {

        public string OrderName { get; set; } = string.Empty;

        public List<Product> Products = new List<Product>();

        public List<Menu> Menus = new List<Menu>();


        public OrderState OrderState { get; set; } = OrderState.Pending;

        public void AddProductToOrder(Product product)
        {
            Products.Add(product);
           
                        
        }
        public List<Product> GetAllProducts()
        {
            return Products;
        }
    }
}
