using Microsoft.AspNetCore.Mvc;
using Modulo05.ValidacaoErros.Interfaces;
using Modulo05.ValidacaoErros.Models;

namespace Modulo05.ValidacaoErros.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly IProduto _service;

    public ProdutosController(IProduto service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get() => Ok(_service);

    [HttpPost]
    public ActionResult<Produto> Post([FromBody] Produto produto)
    {
        var p = _service.Criar(produto);
        return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
    }
}