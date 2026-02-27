using Microsoft.EntityFrameworkCore;
using MyStore.Business.LocNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _context.Products.Remove(p);
            _context.SaveChanges();
        }
    }
}
