using System.ComponentModel.DataAnnotations;

namespace ApplicationEndpointsApp.Presentation.DTOs;

public class SlideEnvironmentRequest
{
    [MaxLength(255)]
    public string? Name { get; set; }

    [MaxLength(255)]
    public string? Region { get; set; }
}

public class SlideEnvironmentResponse
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Region { get; set; }
}
