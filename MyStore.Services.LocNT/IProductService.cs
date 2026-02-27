using MyStore.Business.LocNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
