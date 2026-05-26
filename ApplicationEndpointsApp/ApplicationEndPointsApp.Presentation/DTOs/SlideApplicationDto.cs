using System.ComponentModel.DataAnnotations;

namespace ApplicationEndpointsApp.Presentation.DTOs;

public class SlideApplicationRequest
{
    [MaxLength(255)]
    public string? Name { get; set; }

    [MaxLength(255)]
    public string? Description { get; set; }
}

public class SlideApplicationResponse
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
