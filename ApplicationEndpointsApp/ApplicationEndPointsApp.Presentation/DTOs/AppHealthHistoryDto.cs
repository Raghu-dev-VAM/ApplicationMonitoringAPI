using System.ComponentModel.DataAnnotations;

namespace ApplicationEndpointsApp.Presentation.DTOs;

public class AppHealthHistoryRequest
{
    [Required]
    public long UrlId { get; set; }

    [MaxLength(50)]
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
