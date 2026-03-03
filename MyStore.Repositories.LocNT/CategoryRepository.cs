using Microsoft.EntityFrameworkCore;
using MyStore.Business.LocNT;
using MyStore.DBContext.LocNT;

namespace MyStore.Repositories.LocNT
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MyStoreContext _context;

        public CategoryRepository(MyStoreContext context)
        {
            _context = context;
        }

        public async Task AddCategoryAsync(Category c)
        {
            await _context.Categories.AddAsync(c);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(Category updateCategory)
        {
            var existingCategory = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryId == updateCategory.CategoryId);
            if (existingCategory != null) 
            { 
                existingCategory.CategoryId = updateCategory.CategoryId;
                existingCategory.CategoryName = updateCategory.CategoryName;

                await _context.SaveChangesAsync();
            }

        }
        public async Task<List<Category>> GetCategoriesAsync() 
        { 
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category?> GetCategoryAsync(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
        }

        public async Task DeleteCategoryAsync(Category category)
        {
            _context.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}
