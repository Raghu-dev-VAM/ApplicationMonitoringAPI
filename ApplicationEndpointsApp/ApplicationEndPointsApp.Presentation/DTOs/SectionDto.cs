using System.ComponentModel.DataAnnotations;

namespace ApplicationEndpointsApp.Presentation.DTOs;

public class SectionRequest
{
    [MaxLength(255)]
    public string? Name { get; set; }

    public long? ApplicationId { get; set; }
}

public class SectionResponse
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public long? ApplicationId { get; set; }
    public string? ApplicationName { get; set; }
}
