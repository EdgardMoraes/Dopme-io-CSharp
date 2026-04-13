using Modulo05.JWT.Models;

namespace Modulo05.JWT.Services;

public interface ITarefaService
{
    List<Tarefa> ObterTodas();
    // IEnumerable<Tarefa> ObterTodas();
    Tarefa? ObterPorId(int id);
    Tarefa Criar(Tarefa tarefa);
    void Atualizar(int id, Tarefa tarefa);
    void Remover(int id);
}