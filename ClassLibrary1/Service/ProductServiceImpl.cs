using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Persistance;
using ProjectAPI.Persistance;

namespace AssociationCRMDawanPoe.Service
{
    public class ProductServiceImpl : IProductService
    {

        public IProductRepository ProductRepository { get; set; }


        public ProductServiceImpl(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }


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
