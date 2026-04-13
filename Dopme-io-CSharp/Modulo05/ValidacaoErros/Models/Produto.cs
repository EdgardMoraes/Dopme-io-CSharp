using System.ComponentModel.DataAnnotations;

namespace Modulo05.ValidacaoErros.Models;

public class Produto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Nome é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 e100 caracteres")]
    public string Nome { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Preço é obrigatório")]
    [Range(0.01, 10000, ErrorMessage = "Preço deve estar entre 0.01 e 10000")]
    
    public decimal Preco { get; set; }
    [StringLength(500, ErrorMessage = "Descrição não pode exceder 500caracteres")]
    public string? Descricao { get; set; }
    [Required(ErrorMessage = "Categoria é obrigatória")]
    public string Categoria { get; set; } = string.Empty;
}