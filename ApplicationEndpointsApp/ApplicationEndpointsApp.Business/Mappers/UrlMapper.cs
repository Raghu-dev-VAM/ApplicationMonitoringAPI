using ApplicationEndpointsApp.Business.DTOs;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Business.Mappers;

public static class UrlMapper
{
    public static Url ToDataModel(this UrlRequest request)
    {
        return new Url
        {
            BaseUrl = request.BaseUrl,
            ApplicationId = request.ApplicationId,
            EnvironmentId = request.EnvironmentId,
            Description = request.Description,
            SectionId = request.SectionId,
            Tile = request.Tile
        };
    }

    public static UrlResponse ToResponse(this Url model)
    {
        return new UrlResponse
        {
            Id = model.Id,
            BaseUrl = model.BaseUrl,
            ApplicationId = model.ApplicationId,
            ApplicationName = model.Application?.Name,
            EnvironmentId = model.EnvironmentId,
            EnvironmentName = model.Environment?.Name,
            Description = model.Description,
            SectionId = model.SectionId,
            SectionName = model.Section?.Name,
            Tile = model.Tile
        };
    }

    public static IEnumerable<UrlResponse> ToResponses(this IEnumerable<Url> models)
    {
        return models.Select(m => m.ToResponse());
    }
}
