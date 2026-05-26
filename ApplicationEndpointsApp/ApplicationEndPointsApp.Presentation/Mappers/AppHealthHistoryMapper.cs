namespace ApplicationEndpointsApp.Presentation.Mappers;

public static class AppHealthHistoryMapper
{
    public static Business.DTOs.AppHealthHistoryRequest ToBusinessDto(this DTOs.AppHealthHistoryRequest r) => new()
    {
        UrlId = r.UrlId,
        Status = r.Status,
        Timestamp = r.Timestamp
    };

    public static DTOs.AppHealthHistoryResponse ToResponse(this Business.DTOs.AppHealthHistoryResponse d) => new()
    {
        Id = d.Id,
        UrlId = d.UrlId,
        Status = d.Status,
        Timestamp = d.Timestamp
    };

    public static IEnumerable<DTOs.AppHealthHistoryResponse> ToResponses(this IEnumerable<Business.DTOs.AppHealthHistoryResponse> dtos)
        => dtos.Select(d => d.ToResponse());
}
