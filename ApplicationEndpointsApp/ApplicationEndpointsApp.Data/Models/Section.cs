namespace ApplicationEndpointsApp.Data.Models;

public class Section
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public long? ApplicationId { get; set; }

    public SlideApplication? Application { get; set; }
}
