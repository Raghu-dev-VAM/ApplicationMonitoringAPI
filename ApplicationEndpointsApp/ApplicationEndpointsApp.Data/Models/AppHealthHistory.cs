namespace ApplicationEndpointsApp.Data.Models;

public class AppHealthHistory
{
    public long Id { get; set; }
    public long UrlId { get; set; }
    public string? Status { get; set; }
    public DateTime? Timestamp { get; set; }

    public Url? Url { get; set; }
}
