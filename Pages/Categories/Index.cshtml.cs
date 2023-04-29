using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstWebApp.Models;
using FirstWebApp.Data;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<Category> Categories { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Categories != null)
            {
                Categories = await _context.Categories.ToListAsync();
            }
        }
    }
}
