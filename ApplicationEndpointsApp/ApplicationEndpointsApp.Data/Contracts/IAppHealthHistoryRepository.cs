using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Data.Contracts;

public interface IAppHealthHistoryRepository : IRepository<AppHealthHistory>
{
    Task<IEnumerable<AppHealthHistory>> GetByUrlIdAsync(long urlId, CancellationToken cancellationToken);
}
