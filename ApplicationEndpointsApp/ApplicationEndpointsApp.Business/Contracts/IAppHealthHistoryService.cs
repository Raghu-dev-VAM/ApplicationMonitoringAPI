using ApplicationEndpointsApp.Business.DTOs;

namespace ApplicationEndpointsApp.Business.Contracts;

public interface IAppHealthHistoryService
{
    Task<IEnumerable<AppHealthHistoryResponse>> GetAllAsync(CancellationToken cancellationToken);
    Task<AppHealthHistoryResponse?> GetByIdAsync(long id, CancellationToken cancellationToken);
    Task<IEnumerable<AppHealthHistoryResponse>> GetByUrlIdAsync(long urlId, CancellationToken cancellationToken);
    Task<long> AddAsync(AppHealthHistoryRequest request, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(long id, CancellationToken cancellationToken);
}
