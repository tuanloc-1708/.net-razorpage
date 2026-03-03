using Microsoft.EntityFrameworkCore;
using MyStore.Business.LocNT;
using MyStore.DBContext.LocNT;
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

        public async Task DeleteProductAsync(Product p)
        {
            var existingProduct = await _context.Products.FirstOrDefaultAsync(pr => pr.ProductId == p.ProductId);

            if (existingProduct != null)
            {
                _context.Products.Remove(existingProduct);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateProductAsync(Product p)
        {
            var existingProduct = await _context.Products.FirstOrDefaultAsync(pr => pr.ProductId == p.ProductId);

            if (existingProduct != null)
            {
                existingProduct.ProductName = p.ProductName;
                existingProduct.CategoryId = p.CategoryId;
                existingProduct.UnitPrice = p.UnitPrice;
                existingProduct.UnitsInStock = p.UnitsInStock;

                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }

        public async Task<Product?> GetProductByIDAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task SaveProductAsync(Product p)
        {
            await _context.Products.AddAsync(p);
            await _context.SaveChangesAsync();
        }
        
    }
}
