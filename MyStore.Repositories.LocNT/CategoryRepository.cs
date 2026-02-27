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

        public List<Category> GetCategories() 
        { 
            return _context.Categories.ToList();
        }
    }
}
