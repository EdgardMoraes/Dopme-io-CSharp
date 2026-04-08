using Microsoft.AspNetCore.Mvc;
using Modulo05.ProdutosAPI.Models;

namespace Modulo05.ProdutosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private static List<Cliente> _clientes = new();
        private static int _nextId = 1;

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_clientes);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var cliente = _clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (string.IsNullOrEmpty(cliente.Nome))
            {
                return BadRequest("Nome é obrigatório"); // 400 - Bad request
            }

            cliente.Id = _nextId++;
            _clientes.Add(cliente);
            return CreatedAtAction(nameof(Get), new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, Cliente cliente)
        {
            var clienteExistente = _clientes.FirstOrDefault(c => c.Id == id);
            if (clienteExistente == null)
            {
                return NotFound();
            }

            clienteExistente.Nome = cliente.Nome;
            clienteExistente.Email = cliente.Email;
            clienteExistente.Cidade = cliente.Cidade;
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var clienteExistente = _clientes.FirstOrDefault(c => c.Id == id);
            if (clienteExistente == null)
            {
                return NotFound();
            }

            _clientes.Remove(clienteExistente);
            return NotFound();
        }

        [HttpGet("buscar/{email}")]
        public IActionResult GetByEmail(string email) =>
            _clientes.FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                is { } c
                ? Ok(c)
                : NotFound();

        [HttpGet]
        public IActionResult Get([FromQuery] string nome, [FromQuery] string cidade)
        {
            IEnumerable<Cliente> q = _clientes;
            if (!string.IsNullOrEmpty(nome))
                q = q.Where(n => n.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(cidade))
                q = q.Where(c => (c.Cidade ?? "").Equals(cidade, StringComparison.OrdinalIgnoreCase));
            return Ok(q.ToList());
        }
    }
}