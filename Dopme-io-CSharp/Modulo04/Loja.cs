namespace Semana4;

public class Loja
{
    public string Nome { get; set; }
    private List<Produto> produtos = new List<Produto>();

    public Loja(string nome)
    {
        Nome = nome;
    }

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado à loja");
    }

    public void ListarProdutos()
    {
        Console.WriteLine($"Produtos da {Nome}:\n");
        foreach (var produto in produtos)
        {
            produto.Exibir();
            Console.WriteLine();
        }
    }

    public decimal CalcularValorTotalEstoque()
    {
        decimal total = 0;
        foreach (var p in produtos)
        {
            total += p.ValorTotalEstoque();
        }

        return total;
    }

    public Produto BuscarProduto(string nome)
    {
        foreach (var produto in produtos)
        {
            if (produto.Nome.ToLower() == nome.ToLower())
            {
                return produto;
            }
        }

        return null;
    }
}