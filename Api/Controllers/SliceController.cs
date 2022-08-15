using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
[ApiController]
[Route("Slices")]
public class SliceController : CrudControllerBase<Slice, IRepository<Slice>>
{
    private readonly ILogger<SliceController> _logger;

    public SliceController(ILogger<SliceController> logger, IRepository<Slice> repository) : base(repository)
    {
        _logger = logger;
    }
}
