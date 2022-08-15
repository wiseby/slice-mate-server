using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api.Controllers;
public abstract class CrudControllerBase<TEntity, TDataSource> : Controller where TEntity : class
{
    private readonly TDataSource _dataSource;

    public CrudControllerBase(TDataSource dataSource)
    {
        _dataSource = dataSource;
    }

    [HttpPost]
    public ActionResult<int> Create([FromBody] TEntity entity)
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public ActionResult<TEntity> Read(int id)
    {
        return Ok();
    }

    [HttpGet]
    public ActionResult<IReadOnlyCollection<TEntity>> ReadMany(string search, int cursor)
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        return Ok();
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        base.OnActionExecuting(context);
    }
}