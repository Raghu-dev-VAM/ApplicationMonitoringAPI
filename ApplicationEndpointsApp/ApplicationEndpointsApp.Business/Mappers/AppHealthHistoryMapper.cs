using ApplicationEndpointsApp.Business.DTOs;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Business.Mappers;

public static class AppHealthHistoryMapper
{
    public static AppHealthHistory ToDataModel(this AppHealthHistoryRequest request) => new()
    {
        UrlId = request.UrlId,
        Status = request.Status,
        Timestamp = request.Timestamp
    };

    public static AppHealthHistoryResponse ToResponse(this AppHealthHistory model) => new()
    {
        Id = model.Id,
        UrlId = model.UrlId,
        Status = model.Status,
        Timestamp = model.Timestamp
    };

    public static IEnumerable<AppHealthHistoryResponse> ToResponses(this IEnumerable<AppHealthHistory> models)
        => models.Select(m => m.ToResponse());
}
