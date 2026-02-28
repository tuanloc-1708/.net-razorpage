using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyStore.Business.LocNT;
using MyStore.DBContext.LocNT;

namespace MyStoreRazorPage.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly MyStore.DBContext.LocNT.MyStoreContext _context;

        public IndexModel(MyStore.DBContext.LocNT.MyStoreContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
