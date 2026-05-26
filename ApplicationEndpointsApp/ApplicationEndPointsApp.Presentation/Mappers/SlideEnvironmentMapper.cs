namespace ApplicationEndpointsApp.Presentation.Mappers;

public static class SlideEnvironmentMapper
{
    public static Business.DTOs.SlideEnvironmentRequest ToBusinessDto(this DTOs.SlideEnvironmentRequest r) => new()
    {
        Name = r.Name,
        Region = r.Region
    };

    public static DTOs.SlideEnvironmentResponse ToResponse(this Business.DTOs.SlideEnvironmentResponse d) => new()
    {
        Id = d.Id,
        Name = d.Name,
        Region = d.Region
    };

    public static IEnumerable<DTOs.SlideEnvironmentResponse> ToResponses(this IEnumerable<Business.DTOs.SlideEnvironmentResponse> dtos)
        => dtos.Select(d => d.ToResponse());
}
