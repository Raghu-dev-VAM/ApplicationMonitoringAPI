using ApplicationEndpointsApp.Business.DTOs;

namespace ApplicationEndpointsApp.Business.Contracts;

public interface IUrlService
{
    Task<IEnumerable<UrlResponse>> GetAllAsync(CancellationToken cancellationToken);
    Task<UrlResponse?> GetByIdAsync(long id, CancellationToken cancellationToken);
    Task<IEnumerable<UrlResponse>> GetByApplicationIdAsync(long applicationId, CancellationToken cancellationToken);
    Task<long> AddAsync(UrlRequest request, CancellationToken cancellationToken);
    Task UpdateAsync(long id, UrlRequest request, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(long id, CancellationToken cancellationToken);
}
