using AssociationCRMDawanPoe.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI.ItemDTO
{
    public class ItemDTO
    {
        
        public int? ID { get; set; }
        public Type Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public ItemDTO(Product p)
        {
            ID = p.Id;  
            Name = p.Name;
            Price = p.Price;
            Type = p.GetType();
        }
        public ItemDTO(Menu p)
        {
            ID = p.Id;      
            Name=p.Name;
            Price = p.GetPrice();
            Type = p.GetType();
        }

        public ItemDTO()
        {
        }

        public Product ConvertToProduct()
        {
            Product p = new Product()
            {
                Id = this.ID                
            };
            
            return p;
        }
       
        public static List<Product> GetProducts(List<ItemDTO> itemDTOs)
        {
            return itemDTOs.Where(item => item.Type == new Product().GetType()).Select(w => w.ConvertToProduct()).ToList();
        }
        public Menu ConvertToMenu()
        {
            return new Menu() {Id = this.ID};
        }
        public static List<Menu> GetMenus(List<ItemDTO> itemDTOs)
        {
            return itemDTOs.Where(item => item.Type == new Menu().GetType()).Select(w => w.ConvertToMenu()).ToList();
        }

    }
}
