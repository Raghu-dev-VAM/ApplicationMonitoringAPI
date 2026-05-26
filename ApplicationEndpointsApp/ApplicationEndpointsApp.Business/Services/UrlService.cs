using ApplicationEndpointsApp.Business.Contracts;
using ApplicationEndpointsApp.Business.DTOs;
using ApplicationEndpointsApp.Business.Mappers;
using ApplicationEndpointsApp.Data.Contracts;

namespace ApplicationEndpointsApp.Business.Services;

public class UrlService : IUrlService
{
    private readonly IUrlRepository _urlRepository;

    public UrlService(IUrlRepository repo)
    {
        _urlRepository = repo;
    }

    public async Task<IEnumerable<UrlResponse>> GetAllAsync(CancellationToken cancellationToken)
    {
        var models = await _urlRepository.GetAllAsync(cancellationToken);
        return models.ToResponses();
    }

    public async Task<UrlResponse?> GetByIdAsync(long id, CancellationToken cancellationToken)
    {
        var model = await _urlRepository.GetByIdAsync(id, cancellationToken);
        return model?.ToResponse();
    }

    public async Task<IEnumerable<UrlResponse>> GetByApplicationIdAsync(long applicationId, CancellationToken cancellationToken)
    {
        var models = await _urlRepository.GetByApplicationIdAsync(applicationId, cancellationToken);
        return models.ToResponses();
    }

    public async Task<long> AddAsync(UrlRequest request, CancellationToken cancellationToken)
    {
        return await _urlRepository.AddAsync(request.ToDataModel(), cancellationToken);
    }

    public async Task UpdateAsync(long id, UrlRequest request, CancellationToken cancellationToken)
    {
        var model = request.ToDataModel();
        model.Id = id;
        await _urlRepository.UpdateAsync(model, cancellationToken);
    }

    public async Task<bool> DeleteAsync(long id, CancellationToken cancellationToken)
    {
        return await _urlRepository.DeleteAsync(id, cancellationToken);
    }
}
