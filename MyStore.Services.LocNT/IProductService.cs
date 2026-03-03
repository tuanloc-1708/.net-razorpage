using MyStore.Business.LocNT;

namespace MyStore.Services.LocNT
{
    public interface IProductService
    {
        Task DeleteProductAsync(Product p);
        Task UpdateProductAsync(Product p);
        Task SaveProductAsync(Product p);
        Task<List<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
    }
}
