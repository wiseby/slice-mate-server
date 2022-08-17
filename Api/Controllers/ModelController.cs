using DataAccess.Interfaces;
using DataAccess.Models;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[ApiController]
[Route("Slices/{sliceId}/Models")]
public class ModelController : ControllerBase
{
    private readonly ILogger<ModelController> _logger;
    private readonly IModelService _modelService;

    public ModelController(ILogger<ModelController> logger, IModelService modelService)
    {
        _logger = logger;
        _modelService = modelService;
    }

    [HttpGet("")]
    public async Task<ActionResult<Model>> GetMany([FromRoute] Guid sliceId)
    {
        try
        {
            var result = await _modelService.ReadMany(sliceId);
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpGet("{modelId}")]
    public async Task<ActionResult<Model>> Get([FromRoute] Guid sliceId, [FromRoute] int modelVersion)
    {
        try
        {
            var result = await _modelService.Read(sliceId, modelVersion);
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpPut("{ModelId}")]
    public async Task<ActionResult> Update([FromRoute] Guid sliceId, [FromRoute] int modelVersion, [FromBody] Model model)
    {
        try
        {
            await _modelService.Update(sliceId, modelVersion, model);
            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpPost("")]
    public async Task<ActionResult<Guid>> Create([FromRoute] Guid sliceId, [FromBody] Model model)
    {
        try
        {
            var result = await _modelService.Create(sliceId, model);
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpDelete("{ModelId}")]
    public async Task<ActionResult> Delete([FromRoute] Guid sliceId, [FromRoute] int modelVersion)
    {
        try
        {
            await _modelService.Delete(sliceId, modelVersion);
            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }
}
