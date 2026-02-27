using Microsoft.AspNetCore.Mvc.RazorPages;
using MyStore.Business.LocNT;
using MyStore.Services.LocNT;

namespace MyStoreRazorPage.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public IList<Product> Product { get;set; } = default!;

        public void OnGet()
        {
            Product = _productService.GetAllProducts();
        }
    }
}
