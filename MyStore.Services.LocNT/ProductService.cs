using MyStore.Business.LocNT;
using MyStore.Repositories.LocNT;

namespace MyStore.Services.LocNT
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void DeleteProduct(Product p)
        {
            _productRepository.DeleteProduct(p);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductByID(id);
        }

        public void SaveProduct(Product p)
        {
            _productRepository.SaveProduct(p);  
        }

        public void UpdateProduct(Product p)
        {
            _productRepository.UpdateProduct(p);
        }
    }
}
