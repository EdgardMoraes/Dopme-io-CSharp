namespace SistemaBiblioteca;

public class Livro
{
    public string Titulo
    {
        get;
        set { Titulo = !string.IsNullOrWhiteSpace(value) ? value : "Sem título"; }
    }

    public Autor Autor { get; set; }
    public string ISBN { get; set; }

    public int AnoPublicacao
    {
        get;
        set
        {
            if (value >= 1000 && value <= DateTime.Now.Year)
            {
                AnoPublicacao = value;
            }
        }
    }

    public bool Disponivel { get; set; }
    public decimal Preco { get;
        set { Preco = value > 0 ? value : 0; }
    }

    public Livro(string titulo, Autor autor, string isbn, int anoPublicacao, bool disponivel, decimal preco)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        AnoPublicacao = anoPublicacao;
        Disponivel = true;
        Preco = preco;
    }

    public void Emprestar()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine($"Livro {Titulo} empresatado!");
        }
        else
        {
            Console.WriteLine($"Livro {Titulo} não está disponível");
        }
    }

    public void Devolver()
    {
        Disponivel = true;
        Console.WriteLine($"Livro {Titulo} devolvido!");
    }

    public void Exibir()
    {
        string status = Disponivel ? "📗 Disponível" : "📕 Indisponível";
        Console.WriteLine($"📖 {Titulo}");
        Console.WriteLine($" ISBN: {ISBN}");
        Console.WriteLine($" Autor: {Autor.Nome}");
        Console.WriteLine($" Ano: {AnoPublicacao}");
        Console.WriteLine($" Preço: R$ {Preco:F2}");
        Console.WriteLine($" Status: {status}");
    }

    public void EhAntigo()
    {
        if (AnoPublicacao >= DateTime.Now.Year)
        {
            Console.WriteLine($"O livro {Titulo} possui mais de 20 anos!");
            
        }
    }
}