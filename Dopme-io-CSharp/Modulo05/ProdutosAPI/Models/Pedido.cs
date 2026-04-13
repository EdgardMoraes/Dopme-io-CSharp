namespace Modulo05.ProdutosAPI.Models;

public class Pedido
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public DateTime DataPedido { get; set; }
    public decimal Total { get; set; }
}