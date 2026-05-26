using Microsoft.AspNetCore.Mvc;
using ApplicationEndpointsApp.Business.Contracts;
using ApplicationEndpointsApp.Presentation.DTOs;
using ApplicationEndpointsApp.Presentation.Mappers;

namespace ApplicationEndpointsApp.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SectionsController : ControllerBase
{
    private readonly ISectionService _service;

    public SectionsController(ISectionService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken ct = default)
        => Ok((await _service.GetAllAsync(ct)).ToResponses());

    [HttpGet("{id:long:min(1)}")]
    public async Task<IActionResult> GetById(long id, CancellationToken ct = default)
    {
        var result = await _service.GetByIdAsync(id, ct);
        return result is null ? NotFound() : Ok(result.ToResponse());
    }

    [HttpGet("application/{applicationId:long:min(1)}")]
    public async Task<IActionResult> GetByApplicationId(long applicationId, CancellationToken ct = default)
        => Ok((await _service.GetByApplicationIdAsync(applicationId, ct)).ToResponses());

    [HttpPost]
    public async Task<IActionResult> Create(SectionRequest request, CancellationToken ct = default)
    {
        var newId = await _service.AddAsync(request.ToBusinessDto(), ct);
        return CreatedAtAction(nameof(GetById), new { id = newId }, request);
    }

    [HttpPut("{id:long:min(1)}")]
    public async Task<IActionResult> Update(long id, SectionRequest request, CancellationToken ct = default)
    {
        await _service.UpdateAsync(id, request.ToBusinessDto(), ct);
        return NoContent();
    }

    [HttpDelete("{id:long:min(1)}")]
    public async Task<IActionResult> Delete(long id, CancellationToken ct = default)
        => await _service.DeleteAsync(id, ct) ? NoContent() : NotFound();
}
