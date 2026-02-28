using MyStore.Business.LocNT;

namespace MyStore.Repositories.LocNT
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        void Update(Category category);
        List<Category> GetCategories();
    }
}
