using System.ComponentModel.DataAnnotations;

namespace ApplicationEndpointsApp.Presentation.DTOs;

public class ApplicationEndpointRequest
{
    [Required]
    [MinLength(1)]
    [MaxLength(255)]
    public string ApplicationName { get; set; } = string.Empty;

    [MaxLength(255)]
    public string? Description { get; set; }

}
