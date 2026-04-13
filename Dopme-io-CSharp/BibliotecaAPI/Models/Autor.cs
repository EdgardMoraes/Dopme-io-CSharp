using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaAPI.Models;

[Table("Autores")]
public class Autor
{
    [Key] public int Id { get; set; }
    [Required] [MaxLength(50)] public string Nome { get; set; } = string.Empty;

    [Required] public DateTime DataNascimento { get; set; }

// Navegação
    public List<Livro> Livros { get; set; } = new();
}