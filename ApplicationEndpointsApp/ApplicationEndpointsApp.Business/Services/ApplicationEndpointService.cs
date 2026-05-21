using ApplicationEndpointsApp.Business.Contracts;
using ApplicationEndpointsApp.Business.DTOs;
using ApplicationEndpointsApp.Business.Mappers;
using ApplicationEndpointsApp.Data.Contracts;

namespace ApplicationEndpointsApp.Business.Services;

public class ApplicationEndpointService : IApplicationEndpointsService
{
    private readonly IApplicationEndpointRepository applicationendpointrepository;

    public ApplicationEndpointService(IApplicationEndpointRepository repo)
    {
        applicationendpointrepository = repo;
    }

    public async Task<IEnumerable<ApplicationEndpointResponse>> GetAllAsync(CancellationToken cancellationToken)
    {
        var models = await applicationendpointrepository.GetAllAsync(cancellationToken);
        return models.ToApplicationEndpoints();
    }

    public async Task<ApplicationEndpointResponse?> GetByIdAsync(long id, CancellationToken cancellationToken)
    {
        var model = await applicationendpointrepository.GetByIdAsync(id, cancellationToken);
        return model?.ToApplicationEndpointResponse();
    }

    public async Task<IEnumerable<ApplicationEndpointResponse>> GetByApplicationNameAsync(string applicationName, CancellationToken cancellationToken)
    {
        var models = await applicationendpointrepository.GetByApplicationNameAsync(applicationName, cancellationToken);
        return models.ToApplicationEndpoints();
    }

    public async Task<long> AddAsync(ApplicationEndpointRequest applicationEndpointRequest, CancellationToken cancellationToken)
    {
        return await applicationendpointrepository.AddAsync(applicationEndpointRequest.ToDataModel(), cancellationToken);
    }

    public async Task UpdateAsync(long id, ApplicationEndpointRequest applicationEndpointRequest, CancellationToken cancellationToken)
    {
        var model = applicationEndpointRequest.ToDataModel();
        model.Id = (int)id;
        await applicationendpointrepository.UpdateAsync(model, cancellationToken);
    }

    public async Task<bool> DeleteAsync(long id, CancellationToken cancellationToken)
    {
        return await applicationendpointrepository.DeleteAsync(id, cancellationToken);
    }
}
