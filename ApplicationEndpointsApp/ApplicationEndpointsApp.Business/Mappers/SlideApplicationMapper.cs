using ApplicationEndpointsApp.Business.DTOs;
using ApplicationEndpointsApp.Data.Models;

namespace ApplicationEndpointsApp.Business.Mappers;

public static class SlideApplicationMapper
{
    public static SlideApplication ToDataModel(this SlideApplicationRequest request) => new()
    {
        Name = request.Name,
        Description = request.Description
    };

    public static SlideApplicationResponse ToResponse(this SlideApplication model) => new()
    {
        Id = model.Id,
        Name = model.Name,
        Description = model.Description
    };

    public static IEnumerable<SlideApplicationResponse> ToResponses(this IEnumerable<SlideApplication> models)
        => models.Select(m => m.ToResponse());
}
