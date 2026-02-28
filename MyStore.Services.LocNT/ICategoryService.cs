using MyStore.Business.LocNT;

namespace MyStore.Services.LocNT
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
    }
}
