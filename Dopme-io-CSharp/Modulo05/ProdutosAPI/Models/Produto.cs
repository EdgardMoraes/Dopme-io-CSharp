using System.ComponentModel.DataAnnotations;

namespace Modulo05.ProdutosAPI.Models;

public class Produto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo obrigatório!")]
    [StringLength(100, MinimumLength = 3)]
    public string Nome { get; set; }

    [Range(0.01, 10000, ErrorMessage = "Preço deve ser entre 0.01 e 10000")]
    public double Preco { get; set; }

    [StringLength(500, ErrorMessage = "Descrição não pode exceder 500 char")]
    public string Descricao { get; set; }

    public int CategoriaId { get; set; }
   
}