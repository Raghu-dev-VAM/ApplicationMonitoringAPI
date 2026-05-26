using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Data.Contracts;

public interface ISectionRepository : IRepository<Section>
{
    Task<IEnumerable<Section>> GetByApplicationIdAsync(long applicationId, CancellationToken cancellationToken);
}
