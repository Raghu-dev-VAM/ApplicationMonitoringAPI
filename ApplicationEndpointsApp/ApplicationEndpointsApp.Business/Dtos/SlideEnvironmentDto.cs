namespace ApplicationEndpointsApp.Business.DTOs;

public class SlideEnvironmentRequest
{
    public string? Name { get; set; }
    public string? Region { get; set; }
}

public class SlideEnvironmentResponse
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Region { get; set; }
}
