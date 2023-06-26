using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolio_web_app.Data;
using portfolio_web_app.Models.Domain;
using portfolio_web_app.Models.ViewModels;

namespace portfolio_web_app.Pages.Admin.DevLogs
{
    public class AddModel : PageModel
    {
        private readonly portfolio_web_appContext portfolio_Web_AppContext;
        [BindProperty]
        public AddDevLog AddDevLogRequest { get; set; }

        public AddModel(portfolio_web_appContext portfolio_Web_AppContext)
        {
            this.portfolio_Web_AppContext = portfolio_Web_AppContext;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost() {

            var devLogPost = new DevLogPost()
            {
                Heading = AddDevLogRequest.Heading,
                PageTitle = AddDevLogRequest.PageTitle,
                Content = AddDevLogRequest.PageContent,
                ShortDescription = AddDevLogRequest.ShortDescription,
                FeaturedImageUrl = AddDevLogRequest.FeaturedImageUrl,
                PublishedDate = AddDevLogRequest.PublishedDate,
                UrlHandle = AddDevLogRequest.UrlHandle,
                Author = AddDevLogRequest.Author,
                Visible = AddDevLogRequest.Visible
            };
            portfolio_Web_AppContext.DevLogPosts.AddAsync(devLogPost);
            await portfolio_Web_AppContext.SaveChangesAsync();

            return RedirectToPage("/Admin/DevLogs/List");

        }
    }
}


