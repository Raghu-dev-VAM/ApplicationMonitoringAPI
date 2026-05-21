using Microsoft.AspNetCore.Mvc;
using ApplicationEndpointsApp.Business.Contracts;
using ApplicationEndpointsApp.Presentation.DTOs;
using ApplicationEndpointsApp.Presentation.Mappers;

namespace ApplicationEndpointsApp.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApplicationEndpointsController : ControllerBase
{
    private readonly IApplicationEndpointsService applicationEndpointsService;

    public ApplicationEndpointsController(IApplicationEndpointsService applicationendpointsservice)
    {
        applicationEndpointsService = applicationendpointsservice;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken = default)
    {
        var results = await applicationEndpointsService.GetAllAsync(cancellationToken);
        return Ok(results.ToResponses());
    }

    [HttpGet("{id:long:min(1)}")]
    public async Task<IActionResult> GetById(long id, CancellationToken cancellationToken = default)
    {
        var result = await applicationEndpointsService.GetByIdAsync(id, cancellationToken);
        return result is null ? NotFound() : Ok(result.ToResponse());
    }

    [HttpGet("search/{applicationName:minlength(1)}")]
    public async Task<IActionResult> Search(string applicationName, CancellationToken cancellationToken = default)
    {
        var results = await applicationEndpointsService.GetByApplicationNameAsync(applicationName, cancellationToken);
        return Ok(results.ToResponses());
    }

    [HttpPost]
    public async Task<IActionResult> Create(ApplicationEndpointRequest request, CancellationToken cancellationToken = default)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var newId = await applicationEndpointsService.AddAsync(request.ToBusinessDto(), cancellationToken);
        return CreatedAtAction(nameof(GetById), new { id = newId }, request);
    }

    [HttpPut("{id:long:min(1)}")]
    public async Task<IActionResult> Update(long id, ApplicationEndpointRequest request, CancellationToken cancellationToken = default)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        await applicationEndpointsService.UpdateAsync(id, request.ToBusinessDto(), cancellationToken);
        return NoContent();
    }

    [HttpDelete("{id:long:min(1)}")]
    public async Task<IActionResult> Delete(long id, CancellationToken cancellationToken = default)
    {
        var deleted = await applicationEndpointsService.DeleteAsync(id, cancellationToken);
        return deleted ? NoContent() : NotFound();
    }
}
