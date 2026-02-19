namespace Semana4;

public class Produto
{
    // PROPRIEDADES
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
    public string Descricao { get; set; }

    // CONSTRUTORES

    public Produto(string nome, decimal preco, int estoque, string descricao)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
        Descricao = descricao;
    }

    public Produto(string nome, decimal preco, int estoque) : this(nome, preco, estoque, "sem descrição")
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

    public Produto(string nome, decimal preco) : this(nome, preco, 0, "sem descrição")
    {
        Nome = nome;
        Preco = preco;
    }

    public decimal ValorTotalEstoque() => Preco * Estoque;

    public void Aumentarestoque(int quantidade)
    {
        if (quantidade > 0)
        {
            Estoque += quantidade;
            Console.WriteLine($"{quantidade} unidades adicionadas");
        }
        else
        {
            throw new InvalidOperationException("Quantidade dever ser positiva");
        }
    }

    public void DiminuirEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= Estoque)
        {
            Estoque -= quantidade;
            Console.WriteLine($"{quantidade} unidades vendidades");
        }
        else
        {
            throw new InvalidOperationException("Quantidade inválida ou estoque insuficiente");
        }
    }

    public decimal AplicarDesconto(decimal percentual)
    {
        if (percentual > 0 && percentual < 100)
        {
            return Preco * (1 - percentual / 100);
        }

        return Preco;
    }

    public void Exibir()
    {
        Console.WriteLine($"Produto: {Nome,-20}");
        Console.WriteLine($"Preço: R$ {Preco:f2,21}");
        Console.WriteLine($"Estoque: {Estoque,-23}");
        Console.WriteLine($"Descrição: {Descricao,-19}");
        Console.WriteLine($"Total: R$ {ValorTotalEstoque():f2,18}");
    }

    public bool EstaEmFalta()
    {
        return Estoque == 0;
    }

    public bool EstoqueBaixo(int minimo = 5)
    {
        return Estoque < minimo && Estoque > 0;
    }
}