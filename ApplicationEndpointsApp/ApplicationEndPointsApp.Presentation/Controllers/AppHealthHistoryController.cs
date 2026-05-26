using Microsoft.AspNetCore.Mvc;
using ApplicationEndpointsApp.Business.Contracts;
using ApplicationEndpointsApp.Presentation.DTOs;
using ApplicationEndpointsApp.Presentation.Mappers;

namespace ApplicationEndpointsApp.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppHealthHistoryController : ControllerBase
{
    private readonly IAppHealthHistoryService _service;

    public AppHealthHistoryController(IAppHealthHistoryService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken ct = default)
        => Ok((await _service.GetAllAsync(ct)).ToResponses());

    [HttpGet("{id:long:min(1)}")]
    public async Task<IActionResult> GetById(long id, CancellationToken ct = default)
    {
        var result = await _service.GetByIdAsync(id, ct);
        return result is null ? NotFound() : Ok(result.ToResponse());
    }

    [HttpGet("url/{urlId:long:min(1)}")]
    public async Task<IActionResult> GetByUrlId(long urlId, CancellationToken ct = default)
        => Ok((await _service.GetByUrlIdAsync(urlId, ct)).ToResponses());

    [HttpPost]
    public async Task<IActionResult> Create(AppHealthHistoryRequest request, CancellationToken ct = default)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var newId = await _service.AddAsync(request.ToBusinessDto(), ct);
        return CreatedAtAction(nameof(GetById), new { id = newId }, request);
    }

    [HttpDelete("{id:long:min(1)}")]
    public async Task<IActionResult> Delete(long id, CancellationToken ct = default)
        => await _service.DeleteAsync(id, ct) ? NoContent() : NotFound();
}
