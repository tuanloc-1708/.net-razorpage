using MyStore.Business.LocNT;
using MyStore.Repositories.LocNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Services.LocNT
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        private ProductService(IProductRepository productRepository)
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
