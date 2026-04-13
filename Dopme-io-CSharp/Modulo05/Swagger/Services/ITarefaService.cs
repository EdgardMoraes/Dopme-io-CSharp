using Modulo05.Swagger.Models;

namespace Modulo05.Swagger.Services;

public interface ITarefaService
{
    List<Tarefa> ObterTodas();
    // IEnumerable<Tarefa> ObterTodas();
    Tarefa? ObterPorId(int id);
    Tarefa Criar(Tarefa tarefa);
    void Atualizar(int id, Tarefa tarefa);
    void Remover(int id);
}