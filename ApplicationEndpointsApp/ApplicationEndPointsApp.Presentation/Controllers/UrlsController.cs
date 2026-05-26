using Microsoft.AspNetCore.Mvc;
using ApplicationEndpointsApp.Business.Contracts;
using ApplicationEndpointsApp.Presentation.DTOs;
using ApplicationEndpointsApp.Presentation.Mappers;

namespace ApplicationEndpointsApp.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UrlsController : ControllerBase
{
    private readonly IUrlService _urlService;

    public UrlsController(IUrlService urlService)
    {
        _urlService = urlService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken = default)
    {
        var results = await _urlService.GetAllAsync(cancellationToken);
        return Ok(results.ToResponses());
    }

    [HttpGet("{id:long:min(1)}")]
    public async Task<IActionResult> GetById(long id, CancellationToken cancellationToken = default)
    {
        var result = await _urlService.GetByIdAsync(id, cancellationToken);
        return result is null ? NotFound() : Ok(result.ToResponse());
    }

    [HttpGet("application/{applicationId:long:min(1)}")]
    public async Task<IActionResult> GetByApplicationId(long applicationId, CancellationToken cancellationToken = default)
    {
        var results = await _urlService.GetByApplicationIdAsync(applicationId, cancellationToken);
        return Ok(results.ToResponses());
    }

    [HttpPost]
    public async Task<IActionResult> Create(UrlRequest request, CancellationToken cancellationToken = default)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var newId = await _urlService.AddAsync(request.ToBusinessDto(), cancellationToken);
        return CreatedAtAction(nameof(GetById), new { id = newId }, request);
    }

    [HttpPut("{id:long:min(1)}")]
    public async Task<IActionResult> Update(long id, UrlRequest request, CancellationToken cancellationToken = default)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        await _urlService.UpdateAsync(id, request.ToBusinessDto(), cancellationToken);
        return NoContent();
    }

    [HttpDelete("{id:long:min(1)}")]
    public async Task<IActionResult> Delete(long id, CancellationToken cancellationToken = default)
    {
        var deleted = await _urlService.DeleteAsync(id, cancellationToken);
        return deleted ? NoContent() : NotFound();
    }
}
