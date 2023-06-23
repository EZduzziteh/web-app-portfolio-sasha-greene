using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace portfolio_web_app.Pages.Admin.Blogs
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public string Heading { get; set; }
        [BindProperty]
        public string PageTitle { get; set; }
        [BindProperty]
        public string ShortDescription { get; set; }
        [BindProperty] 
        public string PageContent { get; set; }

        public void OnGet()
        {
        }

        public void OnPost() { 
        
        }
    }
}
