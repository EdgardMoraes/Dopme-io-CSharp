using Microsoft.AspNetCore.Mvc;
using Modulo05.ProdutosAPI.Models;

namespace Modulo05.ProdutosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private static readonly List<Pedido> pedidos = new();
        private static int _nextId = 1;


        [HttpGet(Name = "ListarPedidos")]
        public IActionResult Get() => Ok(pedidos);

        [HttpGet("{id:int}", Name = "GetPedido")]
        public IActionResult Get(int id) => pedidos.FirstOrDefault(c => c.Id == id) is { } c ? Ok(c) : NotFound();

        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            pedido.Id = _nextId++;
            pedidos.Add(pedido);
            return CreatedAtRoute("GetPedido", new { id = pedido.Id }, pedido);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] Pedido pedido)
        {
            var p = pedidos.FindIndex(c => c.Id == id);
            if (p < 0) return NotFound();
            pedido.Id = id;
            pedidos[p] = pedido;
            return NoContent();
        }
        
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var p = pedidos.FindIndex(c => c.Id == id);
            if (p < 0) return NotFound();
            pedidos.RemoveAt(p);
            return NotFound();
        }
    }
}
