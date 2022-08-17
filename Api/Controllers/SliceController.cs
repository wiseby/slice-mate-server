using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[ApiController]
[Route("Slices")]
public class SliceController : ControllerBase
{
    private readonly ILogger<SliceController> _logger;
    private readonly ISliceService _sliceService;

    public SliceController(ILogger<SliceController> logger, ISliceService sliceService)
    {
        _logger = logger;
        _sliceService = sliceService;
    }

    [HttpGet("")]
    public async Task<ActionResult<Slice>> GetMany([FromQuery] string search, [FromQuery] int cursor)
    {
        try
        {
            var result = await _sliceService.ReadMany(search, cursor);
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpGet("{sliceId}")]
    public async Task<ActionResult<Slice>> Get([FromRoute] Guid id)
    {
        try
        {
            var result = await _sliceService.Read(id);
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpPut("{sliceId}")]
    public async Task<ActionResult> Update([FromRoute] Guid id, [FromBody] Slice slice)
    {
        try
        {
            await _sliceService.Update(id, slice);
            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpPost("")]
    public async Task<ActionResult<Guid>> Create([FromBody] Slice slice)
    {
        try
        {
            var result = await _sliceService.Create(slice);
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }


    [HttpDelete("{sliceId}")]
    public async Task<ActionResult> Delete([FromRoute] Guid id)
    {
        try
        {
            await _sliceService.Delete(id);
            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }
}
