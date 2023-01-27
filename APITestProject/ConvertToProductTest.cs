using AssociationCRMDawanPoe.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectAPI.ItemDTO;

namespace APITestProject
{
    [TestClass]
    public class ConvertToProductTest
    {
        ItemDTO? itemDTOMenu;
        ItemDTO? itemDTOProduct;
        Menu? menu;
        Product? product;
        List<ItemDTO>? items;
        
        [TestInitialize]
        public void Setup()
        {
            product=new Product() { Id=1, Name="Produit", Price=1.5};
             menu=new Menu() { Id=2, Name="Menu"};

            itemDTOMenu = new(menu);
            itemDTOProduct =  new(product);
            items = new List<ItemDTO>();
            items.Add(new ItemDTO(product));
            items.Add(new ItemDTO(product));
            items.Add(new ItemDTO(menu));
            items.Add(new ItemDTO(menu));
            items.Add(new ItemDTO(menu));
        }
        [TestCleanup]
        public void Clear()
        {
            itemDTOMenu = null;
            itemDTOProduct = null; 
            menu = null;
            product = null;
            items = null;
        }


        [TestMethod]
        public void ConvertToProductProductReturnProduct()
        {

            Assert.AreEqual(product?.Id, itemDTOProduct?.ConvertToProduct().Id);
            
        }
        [TestMethod]
        public void ConvertToMenuMenuReturnMenu()
        {
            Assert.AreEqual(menu?.Id, itemDTOMenu?.ConvertToMenu().Id);
        }

        [TestMethod]
        public void GetProductsitemsReturn2products()
        {
            //DO:
            List<Product> list = ItemDTO.GetProducts(items);
            Assert.AreEqual(2, list.Count());
        }
        [TestMethod]
        public void GetMenusitemsReturn2Menus()
        {
            //DO:
            List<Menu> list = ItemDTO.GetMenus(items);
            Assert.AreEqual(3, list.Count());
        }

    }
}