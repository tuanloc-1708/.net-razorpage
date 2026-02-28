using MyStore.Business.LocNT;

namespace MyStore.Repositories.LocNT
{
    public interface ICategoryRepository
    {
        Category GetCategory(int id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        List<Category> GetCategories();
    }
}
