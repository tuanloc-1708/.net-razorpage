using MyStore.Business.LocNT;

namespace MyStore.Repositories.LocNT
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}
