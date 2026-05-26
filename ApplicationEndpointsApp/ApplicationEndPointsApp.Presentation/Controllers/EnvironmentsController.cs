using Microsoft.AspNetCore.Mvc;
using ApplicationEndpointsApp.Business.Contracts;
using ApplicationEndpointsApp.Presentation.DTOs;
using ApplicationEndpointsApp.Presentation.Mappers;

namespace ApplicationEndpointsApp.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EnvironmentsController : ControllerBase
{
    private readonly ISlideEnvironmentService _service;

    public EnvironmentsController(ISlideEnvironmentService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken ct = default)
        => Ok((await _service.GetAllAsync(ct)).ToResponses());

    [HttpGet("{id:long:min(1)}")]
    public async Task<IActionResult> GetById(long id, CancellationToken ct = default)
    {
        var result = await _service.GetByIdAsync(id, ct);
        return result is null ? NotFound() : Ok(result.ToResponse());
    }

    [HttpPost]
    public async Task<IActionResult> Create(SlideEnvironmentRequest request, CancellationToken ct = default)
    {
        var newId = await _service.AddAsync(request.ToBusinessDto(), ct);
        return CreatedAtAction(nameof(GetById), new { id = newId }, request);
    }

    [HttpPut("{id:long:min(1)}")]
    public async Task<IActionResult> Update(long id, SlideEnvironmentRequest request, CancellationToken ct = default)
    {
        await _service.UpdateAsync(id, request.ToBusinessDto(), ct);
        return NoContent();
    }

    [HttpDelete("{id:long:min(1)}")]
    public async Task<IActionResult> Delete(long id, CancellationToken ct = default)
        => await _service.DeleteAsync(id, ct) ? NoContent() : NotFound();
}
