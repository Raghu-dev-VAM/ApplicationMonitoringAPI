namespace ApplicationEndpointsApp.Presentation.Mappers;

public static class SectionMapper
{
    public static Business.DTOs.SectionRequest ToBusinessDto(this DTOs.SectionRequest r) => new()
    {
        Name = r.Name,
        ApplicationId = r.ApplicationId
    };

    public static DTOs.SectionResponse ToResponse(this Business.DTOs.SectionResponse d) => new()
    {
        Id = d.Id,
        Name = d.Name,
        ApplicationId = d.ApplicationId,
        ApplicationName = d.ApplicationName
    };

    public static IEnumerable<DTOs.SectionResponse> ToResponses(this IEnumerable<Business.DTOs.SectionResponse> dtos)
        => dtos.Select(d => d.ToResponse());
}
