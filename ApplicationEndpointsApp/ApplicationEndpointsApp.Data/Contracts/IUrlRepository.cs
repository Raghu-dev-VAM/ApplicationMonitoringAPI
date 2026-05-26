using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Data.Contracts;

public interface IUrlRepository : IRepository<Url>
{
    Task<IEnumerable<Url>> GetByApplicationIdAsync(long applicationId, CancellationToken cancellationToken);
}
