namespace ApplicationEndpointsApp.Presentation.DTOs;

public class UrlResponse
{
    public long Id { get; set; }
    public string BaseUrl { get; set; } = string.Empty;
    public long? ApplicationId { get; set; }
    public string? ApplicationName { get; set; }
    public long? EnvironmentId { get; set; }
    public string? EnvironmentName { get; set; }
    public string? Description { get; set; }
    public long? SectionId { get; set; }
    public string? SectionName { get; set; }
    public string Tile { get; set; } = string.Empty;
}
