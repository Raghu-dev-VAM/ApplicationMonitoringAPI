namespace ApplicationEndpointsApp.Business.DTOs;

public class SlideApplicationRequest
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}

public class SlideApplicationResponse
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
