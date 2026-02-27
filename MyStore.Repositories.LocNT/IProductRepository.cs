using MyStore.Business.LocNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
