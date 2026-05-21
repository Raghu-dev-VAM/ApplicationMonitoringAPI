using Microsoft.Win32.SafeHandles;

namespace ApplicationEndpointsApp.Business.DTOs;

public class ApplicationEndpointRequest
{
    public string? ApplicationName { get; set; }
    public string? Description { get; set; }
}
