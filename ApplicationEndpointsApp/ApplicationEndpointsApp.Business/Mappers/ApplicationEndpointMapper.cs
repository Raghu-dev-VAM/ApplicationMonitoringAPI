using ApplicationEndpointsApp.Business.DTOs;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Business.Mappers;

public static class ApplicationEndpointMapper
{
    public static Data.Models.ApplicationEndpoints ToDataModel(this ApplicationEndpointRequest businessModel)
    {
        return new Data.Models.ApplicationEndpoints
        {
            ApplicationName = businessModel.ApplicationName,
            Description = businessModel.Description,
        };
    }

    public static ApplicationEndpointResponse ToApplicationEndpointResponse(this Data.Models.ApplicationEndpoints dataModel)
    {
        return new ApplicationEndpointResponse
        {
            Id = dataModel.Id,
            ApplicationName = dataModel.ApplicationName,
            Description = dataModel.Description,
        };
    }

    public static IEnumerable<ApplicationEndpointResponse> ToApplicationEndpoints(this IEnumerable<Data.Models.ApplicationEndpoints> dataModels)
    {
        return dataModels.Select(dm => dm.ToApplicationEndpointResponse());
    }
}
