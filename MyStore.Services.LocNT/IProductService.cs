using MyStore.Business.LocNT;

namespace MyStore.Services.LocNT
{
    public interface IProductService
    {
        void DeleteProduct(Product p);
        void UpdateProduct(Product p);
        void SaveProduct(Product p);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
