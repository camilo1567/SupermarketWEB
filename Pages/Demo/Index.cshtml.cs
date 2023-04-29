using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages.Demo
{
    public class IndexModel : PageModel
    {
        public string Title { get; set; }

        public void OnGet()
        {
            Title = "CAMILO HORTA";
            
        }
    }
}
