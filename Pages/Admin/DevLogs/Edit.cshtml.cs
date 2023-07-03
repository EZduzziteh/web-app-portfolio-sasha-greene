using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using portfolio_web_app.Data;
using portfolio_web_app.Models.Domain;
using portfolio_web_app.Repositories;

namespace portfolio_web_app.Pages.Admin.DevLogs
{
    public class EditModel : PageModel
    {
        private readonly IDevLogRepository devLogRepository;
		[BindProperty]
        public DevLogPost devLogPost { get; set; }


        public EditModel(IDevLogRepository devLogRepository)
        {
			this.devLogRepository = devLogRepository;
		}

	

		public async Task OnGet(Guid id)
        {
			devLogPost = await devLogRepository.GetAsync(id);

			
        }

		public async Task<IActionResult> OnPostEdit()
		{
            await devLogRepository.UpdateAsync(devLogPost);

            return RedirectToPage("/Admin/DevLogs/List");

        }

        public async Task<IActionResult> OnPostDelete()
        {
            bool deleted = await devLogRepository.DeleteAsync(devLogPost.id);
            if (deleted) {

                return RedirectToPage("/Admin/DevLogs/List");

            }
            return Page();

           
        }
    }
}
