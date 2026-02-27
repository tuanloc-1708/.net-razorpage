using MyStore.Business.LocNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
