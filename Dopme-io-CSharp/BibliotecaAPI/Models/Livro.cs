namespace BibliotecaAPI.Models;

public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public int AnoPublicacao { get; set; }
    public int CategoriaId { get; set; }  //forenstkey
    public int AutorId { get; set; }      //forenstkey
// Navegação
    public Categoria Categoria { get; set; } = null!;
    public Autor Autor { get; set; } = null!;
}