namespace ApplicationEndpointsApp.Business.DTOs;

public class SectionRequest
{
    public string? Name { get; set; }
    public long? ApplicationId { get; set; }
}

public class SectionResponse
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public long? ApplicationId { get; set; }
    public string? ApplicationName { get; set; }
}
