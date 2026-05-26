namespace ApplicationEndpointsApp.Business.DTOs;

public class UrlRequest
{
    public string BaseUrl { get; set; } = string.Empty;
    public long? ApplicationId { get; set; }
    public long? EnvironmentId { get; set; }
    public string? Description { get; set; }
    public long? SectionId { get; set; }
    public string Tile { get; set; } = string.Empty;
}
