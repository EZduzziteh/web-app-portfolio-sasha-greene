using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace portfolio_web_app.Pages
{
    public class testPageModel : PageModel
    {
        public void OnGet()
        {
            Console.WriteLine("hello test from dotnet");
        }
    }
}
