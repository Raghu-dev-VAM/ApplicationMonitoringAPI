using ApplicationEndpointsApp.Business.Contracts;
using ApplicationEndpointsApp.Business.DTOs;
using ApplicationEndpointsApp.Business.Mappers;
using ApplicationEndpointsApp.Data.Contracts;

namespace ApplicationEndpointsApp.Business.Services;

public class SectionService : ISectionService
{
    private readonly ISectionRepository _repo;

    public SectionService(ISectionRepository repo) => _repo = repo;

    public async Task<IEnumerable<SectionResponse>> GetAllAsync(CancellationToken ct)
        => (await _repo.GetAllAsync(ct)).ToResponses();

    public async Task<SectionResponse?> GetByIdAsync(long id, CancellationToken ct)
        => (await _repo.GetByIdAsync(id, ct))?.ToResponse();

    public async Task<IEnumerable<SectionResponse>> GetByApplicationIdAsync(long applicationId, CancellationToken ct)
        => (await _repo.GetByApplicationIdAsync(applicationId, ct)).ToResponses();

    public async Task<long> AddAsync(SectionRequest request, CancellationToken ct)
        => await _repo.AddAsync(request.ToDataModel(), ct);

    public async Task UpdateAsync(long id, SectionRequest request, CancellationToken ct)
    {
        var model = request.ToDataModel();
        model.Id = id;
        await _repo.UpdateAsync(model, ct);
    }

    public async Task<bool> DeleteAsync(long id, CancellationToken ct)
        => await _repo.DeleteAsync(id, ct);
}
