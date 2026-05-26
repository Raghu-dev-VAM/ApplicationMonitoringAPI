namespace ApplicationEndpointsApp.Data.Models;

public class Url
{
    public long Id { get; set; }
    public string BaseUrl { get; set; } = string.Empty;
    public long? ApplicationId { get; set; }
    public long? EnvironmentId { get; set; }
    public string? Description { get; set; }
    public long? SectionId { get; set; }
    public string Tile { get; set; } = string.Empty;

    public SlideApplication? Application { get; set; }
    public SlideEnvironment? Environment { get; set; }
    public Section? Section { get; set; }
}
