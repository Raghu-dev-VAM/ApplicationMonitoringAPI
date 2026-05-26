namespace ApplicationEndpointsApp.Business.DTOs;

public class AppHealthHistoryRequest
{
    public long UrlId { get; set; }
    public string? Status { get; set; }
    public DateTime? Timestamp { get; set; }
}

public class AppHealthHistoryResponse
{
    public long Id { get; set; }
    public long UrlId { get; set; }
    public string? Status { get; set; }
    public DateTime? Timestamp { get; set; }
}
