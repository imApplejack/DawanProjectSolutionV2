using AssociationCRMDawanPoe.Entity;

namespace AssociationCRMDawanPoe.Service
{
    public class ProductServiceMock : IProductService
    {




        public List<Product> FindByCategory(string Category)
        {
            List<Product> products = new List<Product>();
            foreach (Product item in this.GetAll())
            {
                if (item.ProductCategory.ToString() == Category)
                {
                    products.Add(item);
                }
            }
            return products;
        }

        public List<Product> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
        public List<Product> getAllProduct()
        {
            return new List<Product>() {
               new Product() {Id = 0, Name = "Kebab", Price=1, ProductCategory = ProductCategory.Plat},
               new Product() { Id = 1, Name = "Burger", Price = 10 , ProductCategory = ProductCategory.Plat  },
               new Product() { Id = 2, Name = "Cola", Price = 3 , ProductCategory = ProductCategory.Boisson },
               new Product() { Id =3 ,Name = "Limonade", ProductCategory = ProductCategory.Boisson, Price = 3 },
               new Product() { Id =4, Name = "Eau", ProductCategory = ProductCategory.Boisson, Price = 2 },
               new Product() { Id =5, Name = "Galette", ProductCategory = ProductCategory.Plat, Price = 6 },
               new Product() { Id =6, Name = "Tacos", ProductCategory = ProductCategory.Plat, Price = 6 },
               new Product() { Id =7, Name = "Frites", ProductCategory = ProductCategory.Accompagnement, Price = 3 },
               new Product() { Id =8, Name = "Semoule", ProductCategory = ProductCategory.Accompagnement, Price = 2 }


            };
        }
        public List<string> GetAllCategory()
        {
            return new List<string>()
            {
                ProductCategory.Boisson.ToString(),
                ProductCategory.Plat.ToString(),
                ProductCategory.Accompagnement.ToString(),
                ProductCategory.Other.ToString(),

        };

        }

        public void UpdateProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public void Createproduct(Product p)
        {
            throw new NotImplementedException();
        }

        public void RemoveProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
