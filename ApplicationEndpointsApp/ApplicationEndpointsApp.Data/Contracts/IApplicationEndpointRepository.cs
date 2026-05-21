using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Data.Contracts;

public interface IApplicationEndpointRepository : IRepository<ApplicationEndpoints>
{
    Task<IEnumerable<ApplicationEndpoints>> GetByApplicationNameAsync(string applicationName, CancellationToken cancellationToken);
}
