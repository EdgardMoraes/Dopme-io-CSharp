using System.Globalization;

namespace ToDoList;

public class Tarefa
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public bool Concluida { get; set; }
    public DateTime DataCriacao { get; set; }

    public Tarefa(int id, string descricao)
    {
        Id = id;
        Descricao = descricao;
        Concluida = false;
        DataCriacao = DateTime.Now;
    }

    
}