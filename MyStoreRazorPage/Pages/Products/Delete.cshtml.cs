using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyStore.Business.LocNT;
using MyStore.Services.LocNT;

namespace MyStoreRazorPage.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly IProductService _productService;

        public DeleteModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public Product Product { get; set; } = default!;

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _productService.GetProductById(id.Value);

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _productService?.GetProductById(id.Value);

            if (product != null)
            {
                Product = product;
                _productService.DeleteProduct(product);
            }

            return RedirectToPage("./Index");
        }
    }
}
