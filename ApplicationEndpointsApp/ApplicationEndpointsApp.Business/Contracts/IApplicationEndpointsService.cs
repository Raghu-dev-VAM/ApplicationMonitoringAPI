using ApplicationEndpointsApp.Business.DTOs;

namespace ApplicationEndpointsApp.Business.Contracts;

public interface IApplicationEndpointsService
{
    Task<IEnumerable<ApplicationEndpointResponse>> GetAllAsync(CancellationToken cancellationToken);
    Task<ApplicationEndpointResponse?> GetByIdAsync(long id, CancellationToken cancellationToken);
    Task<IEnumerable<ApplicationEndpointResponse>> GetByApplicationNameAsync(string applicationName, CancellationToken cancellationToken);
    Task<long> AddAsync(ApplicationEndpointRequest applicationEndpointRequest, CancellationToken cancellationToken);
    Task UpdateAsync(long id, ApplicationEndpointRequest applicationEndpointRequest, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(long id, CancellationToken cancellationToken);
}
