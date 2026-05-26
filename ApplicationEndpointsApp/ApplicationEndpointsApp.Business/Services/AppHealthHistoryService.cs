using ApplicationEndpointsApp.Business.Contracts;
using ApplicationEndpointsApp.Business.DTOs;
using ApplicationEndpointsApp.Business.Mappers;
using ApplicationEndpointsApp.Data.Contracts;

namespace ApplicationEndpointsApp.Business.Services;

public class AppHealthHistoryService : IAppHealthHistoryService
{
    private readonly IAppHealthHistoryRepository _repo;

    public AppHealthHistoryService(IAppHealthHistoryRepository repo) => _repo = repo;

    public async Task<IEnumerable<AppHealthHistoryResponse>> GetAllAsync(CancellationToken ct)
        => (await _repo.GetAllAsync(ct)).ToResponses();

    public async Task<AppHealthHistoryResponse?> GetByIdAsync(long id, CancellationToken ct)
        => (await _repo.GetByIdAsync(id, ct))?.ToResponse();

    public async Task<IEnumerable<AppHealthHistoryResponse>> GetByUrlIdAsync(long urlId, CancellationToken ct)
        => (await _repo.GetByUrlIdAsync(urlId, ct)).ToResponses();

    public async Task<long> AddAsync(AppHealthHistoryRequest request, CancellationToken ct)
        => await _repo.AddAsync(request.ToDataModel(), ct);

    public async Task<bool> DeleteAsync(long id, CancellationToken ct)
        => await _repo.DeleteAsync(id, ct);
}
