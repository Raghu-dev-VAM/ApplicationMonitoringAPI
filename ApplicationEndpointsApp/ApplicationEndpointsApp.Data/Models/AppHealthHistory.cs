namespace ApplicationEndpointsApp.Data.Models;

public class AppHealthHistory
{
    public long Id { get; set; }
    public long? UrlId { get; set; }
    public int? StatusCode { get; set; }
    public DateTime CheckedAt { get; set; }

    public Url? Url { get; set; }
}
