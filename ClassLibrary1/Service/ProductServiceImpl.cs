using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Persistance;

namespace AssociationCRMDawanPoe.Service
{
    public class ProductServiceImpl : IProductService
    {

        public ProductRepository ProductRepository { get; set; }

        public void Createproduct(Product p)
        {

            this.ProductRepository.Create(p);
        }

        public List<Product> GetAll()
        {
           return this.ProductRepository.GetAll();
        }

        public void RemoveProductById(int id)
        {
            this.ProductRepository.RemoveById(id);
        }

        public void UpdateProduct(Product p)
        {
            this.ProductRepository.Update(p);
        }


    }
}
