using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolio_web_app.Data;
using portfolio_web_app.Models.Domain;
using portfolio_web_app.Models.ViewModels;

namespace portfolio_web_app.Pages.Admin.Blogs
{
    public class AddModel : PageModel
    {
        private readonly portfolio_web_appContext portfolio_Web_AppContext;
        [BindProperty]
        public AddBlogPost AddBlogPostRequest { get; set; }

        public AddModel(portfolio_web_appContext portfolio_Web_AppContext)
        {
            this.portfolio_Web_AppContext = portfolio_Web_AppContext;
        }

        public void OnGet()
        {

        }

        public void OnPost() {

            var blogPost = new BlogPost()
            {
                Heading = AddBlogPostRequest.Heading,
                PageTitle = AddBlogPostRequest.PageTitle,
                Content = AddBlogPostRequest.PageContent,
                ShortDescription = AddBlogPostRequest.ShortDescription,
                FeaturedImageUrl = AddBlogPostRequest.FeaturedImageUrl,
                PublishedDate = AddBlogPostRequest.PublishedDate,
                UrlHandle = AddBlogPostRequest.UrlHandle,
                Author = AddBlogPostRequest.Author,
                Visible = AddBlogPostRequest.Visible
            };
            portfolio_Web_AppContext.BlogPosts.Add(blogPost);
            portfolio_Web_AppContext.SaveChanges();

        }
    }
}


//1:31:55