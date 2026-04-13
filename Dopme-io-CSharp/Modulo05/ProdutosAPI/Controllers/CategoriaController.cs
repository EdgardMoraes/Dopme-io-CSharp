using Microsoft.AspNetCore.Mvc;
using Modulo05.ProdutosAPI.Models;

namespace Modulo05.ProdutosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private static List<Categoria> categorias = new();
        private static List<Produto> produtos = new(); 
        private static int _nextId = 1;

        // [HttpGet]
        // public IActionResult Get()
        // {
        //     return Ok(categorias);
        // }
        [HttpGet]
        public IActionResult Get() => Ok(categorias);


        // [HttpGet("{id:int}")]
        // public IActionResult Get(int id)
        // {
        //     var categoria = categorias.FirstOrDefault(c => c.Id == id);
        //     if (categoria == null)
        //     {
        //         return NotFound();
        //     }
        //
        //     return Ok(categoria);
        // }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id) => categorias.FirstOrDefault(c => c.Id == id) is { }
            c ? Ok(c) : NotFound();


        // [HttpPost]
        // public IActionResult Create(Categoria categoria)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }
        //
        //     if (string.IsNullOrEmpty(categoria.Nome))
        //     {
        //         return BadRequest("Nome é obrigatório"); // 400 - Bad request
        //     }
        //
        //     categoria.Id = _nextId++;
        //     categorias.Add(categoria);
        //     return CreatedAtAction(nameof(Get), new { id = categoria.Id }, categoria);
        // }
        [HttpPost]
        public IActionResult Post([FromBody] Categoria categoria)
        {
            categoria.Id = _nextId++;
            categorias.Add(categoria);
            return CreatedAtAction(nameof(Get), new { id = categoria.Id }, categoria);
        }

        // [HttpPut("{id:int}")]
        // public IActionResult Update(int id, Categoria categoria)
        // {
        //     var categoriaExistente = categorias.FirstOrDefault(c => c.Id == id);
        //     if (categoriaExistente == null)
        //     {
        //         return NotFound();
        //     }
        //
        //     categoriaExistente.Nome = categoria.Nome;
        //     categoriaExistente.Descricao = categoria.Descricao;
        //     return NoContent();
        // }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] Categoria categoria)
        {
            var categoriaExistente = categorias.FindIndex(c => c.Id == id);
            if (categoriaExistente < 0) return NotFound();
            categoria.Id = id;
            categorias[categoriaExistente] = categoria;
            return NoContent();
        }


        // [HttpDelete("{id:int}")]
        // public IActionResult Delete(int id)
        // {
        //     var categoriaExistente = categorias.FirstOrDefault(c => c.Id == id);
        //     if (categoriaExistente == null)
        //     {
        //         return NotFound();
        //     }
        //
        //     categorias.Remove(categoriaExistente);
        //     return NotFound();
        // }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var categoriaExistente = categorias.FindIndex(c => c.Id == id);
            if (categoriaExistente < 0) return NotFound();
            categorias.RemoveAt(categoriaExistente);
            return NotFound();
        }


        // [HttpGet("api/categorias/buscar{nome:minlength(3)}")]
        // public IActionResult GetByName(string nome)
        // {
        //     var categoria = categorias.FirstOrDefault(c => c.Nome == nome);
        //     if (categoria == null)
        //     {
        //         return NotFound();
        //     }
        //
        //     return Ok(categoria);
        // }

        [HttpGet("buscar/{nome:minlength(3)}")]
        public IActionResult GetByName(string nome) =>
            categorias.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                is { } c
                ? Ok(c)
                : NotFound();

        
        // public IActionResult GetByProduto(int id)
        // {
        //     return Ok();
        // }
        [HttpGet("{id:int}")]
        public IActionResult GetByProduto(int id) => Ok(produtos.Where(p => p.CategoriaId == id));

    }
}