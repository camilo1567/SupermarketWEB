using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstWebApp.Models;
using FirstWebApp.Data;

namespace FirstWebApp.Pages.Details
{
    public class CreateModel : PageModel
    {
        private readonly SupermarketContext _context;

        public CreateModel(SupermarketContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Detail Detail { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Categories == null || Detail == null)
            {
                return Page();
            }
            _context.Details.Add(Detail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./index");
        }
    }
}
