using ApplicationEndpointsApp.Business.DTOs;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Business.Mappers;

public static class SlideEnvironmentMapper
{
    public static SlideEnvironment ToDataModel(this SlideEnvironmentRequest request) => new()
    {
        Name = request.Name,
        Region = request.Region
    };

    public static SlideEnvironmentResponse ToResponse(this SlideEnvironment model) => new()
    {
        Id = model.Id,
        Name = model.Name,
        Region = model.Region
    };

    public static IEnumerable<SlideEnvironmentResponse> ToResponses(this IEnumerable<SlideEnvironment> models)
        => models.Select(m => m.ToResponse());
}
