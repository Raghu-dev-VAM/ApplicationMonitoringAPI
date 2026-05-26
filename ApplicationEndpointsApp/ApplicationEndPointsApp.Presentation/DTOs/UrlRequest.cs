using System.ComponentModel.DataAnnotations;

namespace ApplicationEndpointsApp.Presentation.DTOs;

public class UrlRequest
{
    [Required]
    [MaxLength(255)]
    public string BaseUrl { get; set; } = string.Empty;

    public long? ApplicationId { get; set; }
    public long? EnvironmentId { get; set; }

    [MaxLength(255)]
    public string? Description { get; set; }

    public long? SectionId { get; set; }

    [Required]
    [MaxLength(255)]
    public string Tile { get; set; } = string.Empty;
}
