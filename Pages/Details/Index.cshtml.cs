using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstWebApp.Models;
using FirstWebApp.Data;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp.Pages.Details
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<Detail> Details { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Details != null)
            {
                Details = await _context.Details.ToListAsync();
            }
        }
    }
}
