namespace ApplicationEndpointsApp.Presentation.Mappers;

public static class SlideApplicationMapper
{
    public static Business.DTOs.SlideApplicationRequest ToBusinessDto(this DTOs.SlideApplicationRequest r) => new()
    {
        Name = r.Name,
        Description = r.Description
    };

    public static DTOs.SlideApplicationResponse ToResponse(this Business.DTOs.SlideApplicationResponse d) => new()
    {
        Id = d.Id,
        Name = d.Name,
        Description = d.Description
    };

    public static IEnumerable<DTOs.SlideApplicationResponse> ToResponses(this IEnumerable<Business.DTOs.SlideApplicationResponse> dtos)
        => dtos.Select(d => d.ToResponse());
}
