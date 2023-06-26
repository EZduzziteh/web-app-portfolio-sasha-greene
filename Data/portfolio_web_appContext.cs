using Microsoft.EntityFrameworkCore;
using portfolio_web_app.Models.Domain;

namespace portfolio_web_app.Data
{
    public class portfolio_web_appContext : DbContext
    {
        public portfolio_web_appContext(DbContextOptions options) : base(options)
        {

        }

        //#TODO maybe error here
        public DbSet<DevLogPost> DevLogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
