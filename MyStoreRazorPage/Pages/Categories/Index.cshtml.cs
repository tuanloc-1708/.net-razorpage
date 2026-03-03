using Microsoft.AspNetCore.Mvc.RazorPages;
using MyStore.Business.LocNT;
using MyStore.Services.LocNT;

namespace MyStoreRazorPage.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public IndexModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OngetAsync()
        {
            Category = await _categoryService.GetCategoriesAsync();
        }
    }
}
