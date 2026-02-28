using Microsoft.EntityFrameworkCore;
using MyStore.Business.LocNT;
using MyStore.DBContext.LocNT;

namespace MyStore.Repositories.LocNT
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyStoreContext _context;
        
        public ProductRepository (MyStoreContext context)
        {
            _context = context;
        }

        public void DeleteProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }

        public Product GetProductByID(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public void SaveProduct(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
        }

       
        public void UpdateProduct(Product p)
        {
            var existingProduct = _context.Products.FirstOrDefault(p => p.ProductId == p.ProductId);

            if (existingProduct != null)
            {
                existingProduct.ProductName = p.ProductName;
                existingProduct.CategoryId = p.CategoryId;
                existingProduct.UnitPrice = p.UnitPrice;
                existingProduct.UnitsInStock = p.UnitsInStock;

             
                _context.SaveChanges();
            }
        }
    }
}
