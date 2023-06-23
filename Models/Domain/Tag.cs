namespace portfolio_web_app.Models.Domain
{
    public class Tag
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public Guid BlogPostId { get;set;}
    }
}
