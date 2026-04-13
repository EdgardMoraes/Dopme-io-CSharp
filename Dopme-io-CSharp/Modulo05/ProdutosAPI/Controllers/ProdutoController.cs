using Microsoft.AspNetCore.Mvc;
using Modulo05.ProdutosAPI.Models;

namespace Modulo05.ProdutosAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    private static List<Produto> _produtos = new();

    private static int _nextid = 1;

    // GETALL
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_produtos);
    }

    //GET ID
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var produto = _produtos.FirstOrDefault(p => p.Id == id);
        if (produto == null)
        {
            return NotFound(); // 404 - Not Found
        }

        return Ok(produto); // 200 - OK
    }

    // POST /api/produtos
    [HttpPost]
    public IActionResult Create(Produto produto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (string.IsNullOrEmpty(produto.Nome))
        {
            return BadRequest("Nome é obrigatório"); // 400 - Bad request
        }

        produto.Id = _nextid++;
        _produtos.Add(produto);
        return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto); // 201 - Created
    }

    //PUT /api/produtos
    [HttpPut("{id}")]
    public IActionResult Update(int id, Produto produto)
    {
        var produtoExistente = _produtos.FirstOrDefault(p => p.Id == id);
        if (produtoExistente == null)
        {
            return NotFound(); // 404 - Not Found
        }

        produtoExistente.Nome = produto.Nome;
        produtoExistente.Preco = produto.Preco;
        produtoExistente.Descricao = produto.Descricao;
        return NoContent();
    }
    
    // DELETE api/produtos
    public IActionResult Delete(int id)
    {
        var produto = _produtos.FirstOrDefault(p => p.Id == id);
        if (produto == null)
        {
            return NotFound();
        }

        _produtos.Remove(produto);
        return NoContent();
    }
}