using Microsoft.AspNetCore.Mvc;
using Modulo05.ServiceLifetime.Services;

namespace Modulo05.ServiceLifetime.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContadorController(
    ContadorSingletonService singleton,
    ContadorScopedService scoped,
    ContadorTransienteService transiente)
    : ControllerBase
{
    [HttpGet]
    public ActionResult<object> Get() => Ok
    // public IActionResult Get() => Ok
    (
        new
        {
            singleton = singleton.Incrementar(),
            scoped = scoped.Incrementar(),
            transiente = transiente.Incrementar()
        }
    );
}