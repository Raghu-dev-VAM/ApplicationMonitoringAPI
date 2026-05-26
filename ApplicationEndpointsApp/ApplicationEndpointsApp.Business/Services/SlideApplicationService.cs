using ApplicationEndpointsApp.Business.Contracts;
using ApplicationEndpointsApp.Business.DTOs;
using ApplicationEndpointsApp.Business.Mappers;
using ApplicationEndpointsApp.Data.Contracts;

namespace ApplicationEndpointsApp.Business.Services;

public class SlideApplicationService : ISlideApplicationService
{
    private readonly ISlideApplicationRepository _repo;

    public SlideApplicationService(ISlideApplicationRepository repo) => _repo = repo;

    public async Task<IEnumerable<SlideApplicationResponse>> GetAllAsync(CancellationToken ct)
        => (await _repo.GetAllAsync(ct)).ToResponses();

    public async Task<SlideApplicationResponse?> GetByIdAsync(long id, CancellationToken ct)
        => (await _repo.GetByIdAsync(id, ct))?.ToResponse();

    public async Task<long> AddAsync(SlideApplicationRequest request, CancellationToken ct)
        => await _repo.AddAsync(request.ToDataModel(), ct);

    public async Task UpdateAsync(long id, SlideApplicationRequest request, CancellationToken ct)
    {
        var model = request.ToDataModel();
        model.Id = id;
        await _repo.UpdateAsync(model, ct);
    }

    public async Task<bool> DeleteAsync(long id, CancellationToken ct)
        => await _repo.DeleteAsync(id, ct);
}
