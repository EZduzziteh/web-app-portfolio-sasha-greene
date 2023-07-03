using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolio_web_app.Data;
using portfolio_web_app.Models.Domain;
using portfolio_web_app.Models.ViewModels;
using portfolio_web_app.Repositories;

namespace portfolio_web_app.Pages.Admin.DevLogs
{
    public class AddModel : PageModel
    {
        private readonly IDevLogRepository devLogRepository;
        [BindProperty]
        public AddDevLog AddDevLogRequest { get; set; }

        public AddModel(IDevLogRepository devLogRepository) { 
            this.devLogRepository = devLogRepository;
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

            await devLogRepository.AddAsync(devLogPost);

            return RedirectToPage("/Admin/DevLogs/List");

        }
    }
}


