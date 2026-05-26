using ApplicationEndpointsApp.Business.DTOs;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Business.Mappers;

public static class SectionMapper
{
    public static Section ToDataModel(this SectionRequest request) => new()
    {
        Name = request.Name,
        ApplicationId = request.ApplicationId
    };

    public static SectionResponse ToResponse(this Section model) => new()
    {
        Id = model.Id,
        Name = model.Name,
        ApplicationId = model.ApplicationId,
        ApplicationName = model.Application?.Name
    };

    public static IEnumerable<SectionResponse> ToResponses(this IEnumerable<Section> models)
        => models.Select(m => m.ToResponse());
}
