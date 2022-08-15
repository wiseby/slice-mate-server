using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api.Controllers;
[ApiController]
[Route("Slices/{sliceId:int}/Versions")]
public class VersionController : CrudControllerBase<Version, IRepository<Version>>
{
    private readonly ILogger<VersionController> _logger;
    private int _sliceId;

    public VersionController(ILogger<VersionController> logger, IRepository<Version> repository) : base(repository)
    {
        _logger = logger;
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        _sliceId = int.Parse(context.RouteData.Values["sliceId"].ToString());
        base.OnActionExecuting(context);
    }
}
