namespace BibliotecaAPI.Models;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
// Navegação
    public List<Livro> Livros { get; set; } = new();
}