using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using portfolio_web_app.Data;
using portfolio_web_app.Models.Domain;

namespace portfolio_web_app.Pages.Admin.DevLogs
{
    public class ListModel : PageModel
    {
        private readonly portfolio_web_appContext context;

        public List<DevLogPost> devLogPosts { get; set; }
        public ListModel(portfolio_web_appContext context)
        {
            this.context = context;
        }

       

        public async Task OnGet()
        {
            //#TODO maybe error here
            devLogPosts = await context.DevLogPosts.ToListAsync();

        }
    }
}
