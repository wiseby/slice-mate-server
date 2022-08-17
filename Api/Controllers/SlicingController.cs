using DataAccess.Interfaces;
using DataAccess.Models;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[ApiController]
[Route("Slice/{sliceId}/Models/{modelVersion}/Slicings")]
public class SlicingController : ControllerBase
{
    private readonly ILogger<SlicingController> _logger;
    private readonly ISlicingService _slicingService;

    public SlicingController(ILogger<SlicingController> logger, ISlicingService slicingService)
    {
        _logger = logger;
        _slicingService = slicingService;
    }

    [HttpGet("")]
    public async Task<ActionResult<Slicing>> GetMany([FromRoute] Guid sliceId, [FromRoute] int modelVersion)
    {
        try
        {
            var result = await _slicingService.ReadMany(sliceId, modelVersion);
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpGet("{slicingVersion}")]
    public async Task<ActionResult<Model>> Get([FromRoute] Guid sliceId, [FromRoute] int modelVersion, [FromRoute] int slicingVersion)
    {
        try
        {
            var result = await _slicingService.Read(sliceId, modelVersion, slicingVersion);
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpPut("{slicingVersion}")]
    public async Task<ActionResult> Update([FromRoute] Guid sliceId, [FromRoute] int modelVersion, [FromRoute] int slicingVersion, [FromBody] Slicing slicing)
    {
        try
        {
            await _slicingService.Update(sliceId, modelVersion, slicingVersion, slicing);
            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpPost("")]
    public async Task<ActionResult<Guid>> Create([FromRoute] Guid sliceId, [FromRoute] int modelVersion, [FromBody] Slicing slicing)
    {
        try
        {
            var result = await _slicingService.Create(sliceId, modelVersion, slicing);
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpDelete("{slicingVersion}")]
    public async Task<ActionResult> Delete([FromRoute] Guid sliceId, [FromRoute] int modelVersion, [FromRoute] int slicingVersion)
    {
        try
        {
            await _slicingService.Delete(sliceId, modelVersion, slicingVersion);
            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }
}
