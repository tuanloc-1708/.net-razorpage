using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyStore.Business.LocNT;
using MyStore.Services.LocNT;

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

        public IActionResult OnGet()
        {   
            var categories = _categoryService.GetCategories();
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;

        public  IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                var categories = _categoryService.GetCategories();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName");
                return Page();
            }

            _productService.DeleteProduct(Product);

            return RedirectToPage("./Index");
        }
    }
}
