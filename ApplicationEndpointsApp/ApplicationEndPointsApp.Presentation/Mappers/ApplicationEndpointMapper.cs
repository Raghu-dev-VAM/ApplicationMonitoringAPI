namespace ApplicationEndpointsApp.Presentation.Mappers;

public static class ApplicationEndpointMapper
{
    public static Business.DTOs.ApplicationEndpointRequest ToBusinessDto(this Presentation.DTOs.ApplicationEndpointRequest request)
    {
        return new Business.DTOs.ApplicationEndpointRequest
        {
            ApplicationName = request.ApplicationName,
            Description = request.Description
        };
    }

    public static Presentation.DTOs.ApplicationEndpointResponse ToResponse(this Business.DTOs.ApplicationEndpointResponse dto)
    {
        return new Presentation.DTOs.ApplicationEndpointResponse
        {
            Id = dto.Id,
            ApplicationName = dto.ApplicationName,
            Description = dto.Description
        };
    }

    public static IEnumerable<Presentation.DTOs.ApplicationEndpointResponse> ToResponses(this IEnumerable<Business.DTOs.ApplicationEndpointResponse> dtos)
    {
        return dtos.Select(dto => dto.ToResponse());
    }
}
