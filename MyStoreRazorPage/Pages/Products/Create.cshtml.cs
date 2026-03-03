using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyStore.Business.LocNT;
using MyStore.Services.LocNT;
using System.Threading.Tasks;

namespace MyStoreRazorPage.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public CreateModel(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> OnGetAsync()
        {   
            var categories = await _categoryService.GetCategoriesAsync();
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;

        public  async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("Product.Category");
            if (!ModelState.IsValid)
            {
                var categories = await _categoryService.GetCategoriesAsync();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName");
                return Page();
            }

            await _productService.SaveProductAsync(Product);

            return RedirectToPage("./Index");
        }
    }
}
