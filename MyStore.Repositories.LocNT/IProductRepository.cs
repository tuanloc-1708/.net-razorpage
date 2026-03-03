using MyStore.Business.LocNT;

namespace MyStore.Repositories.LocNT
{
    public interface IProductRepository
    {
        Task SaveProductAsync(Product p);
        Task DeleteProductAsync(Product p);
        Task UpdateProductAsync(Product p);
        Task<List<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIDAsync(int id);
    }
}
