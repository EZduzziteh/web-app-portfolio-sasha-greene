using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using portfolio_web_app.Data;
using portfolio_web_app.Models.Domain;

namespace portfolio_web_app.Pages.Admin.DevLogs
{
    public class EditModel : PageModel
    {
		private readonly portfolio_web_appContext appContext;
		[BindProperty]
        public DevLogPost devLogPost { get; set; }
        public EditModel(portfolio_web_appContext appContext)
        {
			this.appContext = appContext;
		}

	

		public async Task OnGet(Guid id)
        {
			devLogPost = await appContext.DevLogPosts.FindAsync(id);

			
        }

		public async Task<IActionResult> OnPostEdit()
		{
            var existingDevLogPost = await appContext.DevLogPosts.FindAsync(devLogPost.id);

			if(existingDevLogPost!= null)
			{
				existingDevLogPost.Heading = devLogPost.Heading;
				existingDevLogPost.PageTitle = devLogPost.PageTitle;
                existingDevLogPost.Content = devLogPost.Content;
                existingDevLogPost.ShortDescription = devLogPost.ShortDescription;
                existingDevLogPost.FeaturedImageUrl = devLogPost.FeaturedImageUrl;
				existingDevLogPost.UrlHandle = devLogPost.UrlHandle;
                existingDevLogPost.PublishedDate = devLogPost.PublishedDate;
                existingDevLogPost.Author = devLogPost.Author;
                existingDevLogPost.Visible = devLogPost.Visible;

			}

            await appContext.SaveChangesAsync();

            return RedirectToPage("/Admin/DevLogs/List");

        }

        public async Task<IActionResult> OnPostDelete()
        {
            var existingDevLogPost = await appContext.DevLogPosts.FindAsync(devLogPost.id);

            if (existingDevLogPost != null)
            {
               appContext.DevLogPosts.Remove(existingDevLogPost);
               await appContext.SaveChangesAsync();
               return RedirectToPage("/Admin/DevLogs/List");
            }

            return Page();

           
        }
    }
}
