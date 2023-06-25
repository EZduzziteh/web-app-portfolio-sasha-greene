using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolio_web_app.Data;
using portfolio_web_app.Models.Domain;

namespace portfolio_web_app.Pages.Admin.Blogs
{
    public class ListModel : PageModel
    {
        private readonly portfolio_web_appContext context;

        public List<BlogPost> blogPosts { get; set; }
        public ListModel(portfolio_web_appContext context)
        {
            this.context = context;
        }

       

        public void OnGet()
        {
            blogPosts = context.BlogPosts.ToList();

        }
    }
}
