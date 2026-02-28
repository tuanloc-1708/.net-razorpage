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

        public void AddCategory(Category c)
        {
            _context.Categories.Add(c);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category updateCategory)
        {
            var existongCategory = _context.Categories.FirstOrDefault(c => c.CategoryId == updateCategory.CategoryId);
            if (existongCategory != null) 
            { 
                existongCategory.CategoryId = updateCategory.CategoryId;
                existongCategory.CategoryName = updateCategory.CategoryName;

                _context.SaveChanges();
            }

        }
        public List<Category> GetCategories() 
        { 
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public void DeleteCategory(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }
    }
}
