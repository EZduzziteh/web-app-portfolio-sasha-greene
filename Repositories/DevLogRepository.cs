using Microsoft.EntityFrameworkCore;
using portfolio_web_app.Data;
using portfolio_web_app.Models.Domain;
using System;

namespace portfolio_web_app.Repositories
{
	public class DevLogRepository : IDevLogRepository
	{

		private readonly portfolio_web_appContext dbContext;
        public DevLogRepository(portfolio_web_appContext dbContext)
        {
			this.dbContext = dbContext;		
        }

        public async Task<DevLogPost> AddAsync(DevLogPost devLogPost)
		{
			await dbContext.DevLogPosts.AddAsync(devLogPost);
			await dbContext.SaveChangesAsync();
			return devLogPost;
		}

		public async Task<bool> DeleteAsync(Guid id)
		{
			var existingDevLogPost = await dbContext.DevLogPosts.FindAsync(id);

			if (existingDevLogPost != null)
			{
				dbContext.DevLogPosts.Remove(existingDevLogPost);
				await dbContext.SaveChangesAsync();
				return true;
			}

			return false;
		}

		public async Task<IEnumerable<DevLogPost>> GetAllAsync()
		{
			return await dbContext.DevLogPosts.ToListAsync();
		}

		public async Task<DevLogPost> GetAsync(Guid id)
		{
			return await dbContext.DevLogPosts.FindAsync(id);

		}

		public async Task<DevLogPost> UpdateAsync(DevLogPost devLogPost)
		{
			var existingDevLogPost = await dbContext.DevLogPosts.FindAsync(devLogPost.id);

			if (existingDevLogPost != null)
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

			await dbContext.SaveChangesAsync();
			return existingDevLogPost;
		}
	}
}
