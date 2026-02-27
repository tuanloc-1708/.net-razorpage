using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyStore.Business.LocNT;

namespace MyStoreRazorPage.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly MyStore.DBContext.LocNT.MyStoreContext _context;

        public DetailsModel(MyStore.DBContext.LocNT.MyStoreContext context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);
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
    }
}
