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

        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryRepository.DeleteCategory(category);
        }

        public List<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }

        public Category GetCategory(int id)
        {
            return _categoryRepository.GetCategory(id);
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.UpdateCategory(category);
        }
    }
}
