using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using portfolio_web_app.Data;
using portfolio_web_app.Models.Domain;
using portfolio_web_app.Repositories;

namespace portfolio_web_app.Pages.Admin.DevLogs
{
    public class ListModel : PageModel
    {
        private readonly IDevLogRepository devLogRepository;

        public List<DevLogPost> devLogPosts { get; set; }
        public ListModel(IDevLogRepository devLogRepository)
        {
            this.devLogRepository = devLogRepository;
        }

       

        public async Task OnGet()
        {
            //#TODO maybe error here
            devLogPosts = (await devLogRepository.GetAllAsync())?.ToList();

        }
    }
}
