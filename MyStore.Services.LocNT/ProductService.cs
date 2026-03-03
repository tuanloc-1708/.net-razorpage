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
        public async Task DeleteProductAsync(Product p)
        {
            await _productRepository.DeleteProductAsync(p);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetProductByIDAsync(id);
        }

        public async Task SaveProductAsync(Product p)
        {
            await _productRepository.SaveProductAsync(p);  
        }

        public async Task UpdateProductAsync(Product p)
        {
            await _productRepository.UpdateProductAsync(p);
        }
    }
}
