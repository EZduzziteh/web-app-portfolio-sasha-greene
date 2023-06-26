namespace portfolio_web_app.Models.ViewModels
{
    public class AddDevLog
    {
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string PageContent { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }
    }
}
