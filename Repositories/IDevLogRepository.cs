using portfolio_web_app.Models.Domain;

namespace portfolio_web_app.Repositories
{
	public interface IDevLogRepository
	{
		Task<IEnumerable<DevLogPost>> GetAllAsync();
		Task<DevLogPost> GetAsync(Guid id);
		Task<DevLogPost> AddAsync(DevLogPost devLogPost);
		Task<DevLogPost> UpdateAsync(DevLogPost devLogPost);
		Task<bool> DeleteAsync(Guid id);
	}
}
