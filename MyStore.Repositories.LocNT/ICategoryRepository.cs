using MyStore.Business.LocNT;

namespace MyStore.Repositories.LocNT
{
    public interface ICategoryRepository
    {
        Task<Category?> GetCategoryAsync(int id);
        Task AddCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task DeleteCategoryAsync(Category category);
        Task<List<Category>> GetCategoriesAsync();
    }
}
