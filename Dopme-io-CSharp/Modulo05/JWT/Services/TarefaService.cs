using Modulo05.JWT.Models;

namespace Modulo05.JWT.Services;

public class TarefaService : ITarefaService
{
    private static readonly List<Tarefa> _tarefas = new();
    private static int _nextId = 1;


    // public List<Tarefa> ObterTodas() => _tarefas;
    public List<Tarefa> ObterTodas() => _tarefas.ToList();

    public Tarefa? ObterPorId(int id) => _tarefas.FirstOrDefault(t => t.Id == id);


    public Tarefa Criar(Tarefa tarefa)
    {
        tarefa.Id = _nextId++;
        _tarefas.Add(tarefa);
        return tarefa;
    }

    public void Atualizar(int id, Tarefa tarefa)
    {
        var t = _tarefas.FindIndex(t => t.Id == id);
        if (t < 0) throw new KeyNotFoundException();
        tarefa.Id = id;
        _tarefas[t] = tarefa;
    }

    public void Remover(int id)
    {
        var t = _tarefas.FindIndex(t => t.Id == id);
        if (t < 0) throw new KeyNotFoundException();
        _tarefas.RemoveAt(t);
    }
}