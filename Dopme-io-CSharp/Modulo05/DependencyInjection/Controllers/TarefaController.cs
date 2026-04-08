using Microsoft.AspNetCore.Mvc;
using Modulo05.DependencyInjection.Models;
using Modulo05.DependencyInjection.Services;

namespace Modulo05.DependencyInjection.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TarefaController : ControllerBase
{
    private readonly ITarefaService _service;

    // public TarefaController(ITarefaService service)
    // {
    //     _service = service;
    // }

    public TarefaController(ITarefaService service) => _service = service;

    // [HttpGet]
    // public ActionResult<List<Tarefa>> GetAll()
    // {
    //    return Ok(_service.ObterTodas());  
    // } 

    [HttpGet]
    public ActionResult<List<Tarefa>> Get() => Ok(_service.ObterTodas());

    // [HttpGet("{id:int}")]
    // public ActionResult<List<Tarefa>> Get(int id)
    // {
    //     
    //     if (id == null ) NotFound();
    //
    //    return Ok(_service.ObterPorId(id));
    // }

    [HttpGet("{id:int}")]
    public ActionResult<List<Tarefa>> Get(int id) => _service.ObterPorId(id) is { } ? Ok(id) : NotFound();


    [HttpPost]
    public ActionResult<Tarefa> Post([FromBody] Tarefa tarefa)
    {
        var t = _service.Criar(tarefa);
        return CreatedAtAction(nameof(Get), new { id = tarefa.Id }, tarefa);

    }

    [HttpPut("{id:int}")]
    public IActionResult Put(int id, [FromBody] Tarefa tarefa)
    {
     var idExiste = _service.Equals(id);
     if (!idExiste) NotFound();
     _service.Atualizar(id, tarefa);
     return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        // if (id == null) NotFound();
        var idExiste = _service.Equals(id);
        if (!idExiste) NotFound();
        _service.Remover(id);
        return NoContent();
    }
}
