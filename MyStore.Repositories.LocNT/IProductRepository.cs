using MyStore.Business.LocNT;

namespace MyStore.Repositories.LocNT
{
    public interface IProductRepository
    {
        void SaveProduct(Product p);
        void DeleteProduct(Product p);
        void UpdateProduct(Product p);
        List<Product> GetAllProducts();
        Product GetProductByID(int id);
    }
}
