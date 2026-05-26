namespace ApplicationEndpointsApp.Presentation.Mappers;

public static class UrlMapper
{
    public static Business.DTOs.UrlRequest ToBusinessDto(this Presentation.DTOs.UrlRequest request)
    {
        return new Business.DTOs.UrlRequest
        {
            BaseUrl = request.BaseUrl,
            ApplicationId = request.ApplicationId,
            EnvironmentId = request.EnvironmentId,
            Description = request.Description,
            SectionId = request.SectionId,
            Tile = request.Tile
        };
    }

    public static Presentation.DTOs.UrlResponse ToResponse(this Business.DTOs.UrlResponse dto)
    {
        return new Presentation.DTOs.UrlResponse
        {
            Id = dto.Id,
            BaseUrl = dto.BaseUrl,
            ApplicationId = dto.ApplicationId,
            ApplicationName = dto.ApplicationName,
            EnvironmentId = dto.EnvironmentId,
            EnvironmentName = dto.EnvironmentName,
            Description = dto.Description,
            SectionId = dto.SectionId,
            SectionName = dto.SectionName,
            Tile = dto.Tile
        };
    }

    public static IEnumerable<Presentation.DTOs.UrlResponse> ToResponses(this IEnumerable<Business.DTOs.UrlResponse> dtos)
    {
        return dtos.Select(dto => dto.ToResponse());
    }
}
