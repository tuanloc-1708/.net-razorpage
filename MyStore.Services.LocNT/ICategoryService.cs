using MyStore.Business.LocNT;

namespace MyStore.Services.LocNT
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesAsync();
        Task AddCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task DeleteCategoryAsync(Category category);
        Task<Category?> GetCategoryAsync(int id);
    }
}
