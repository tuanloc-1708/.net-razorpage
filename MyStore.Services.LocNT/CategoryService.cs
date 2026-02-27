using MyStore.Business.LocNT;
using MyStore.Repositories.LocNT;

namespace MyStore.Services.LocNT
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }

    }
}
