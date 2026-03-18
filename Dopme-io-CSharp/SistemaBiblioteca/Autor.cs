namespace SistemaBiblioteca;

public class Autor
{
    public string Nome
    {
        get;
        set { Nome = !string.IsNullOrEmpty(value) ? value : "Desconhecido"; }
    }

    public string Email
    {
        get;
        set { Email = !string.IsNullOrEmpty(value) && value.Contains("@") ? value : "email@desconhecido.com"; }
    }

    public DateTime? DataNascimento { get; set; }


    public string Nacionalidade { get; set; }

    public Autor(string nome, string email, DateTime dataNascimento, string nacionalidade)
    {
        Nome = nome;
        Email = email;
        DataNascimento = dataNascimento;
        Nacionalidade = nacionalidade;
    }

    public void Exibir()
    {
        Console.WriteLine("Dados do Autor");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Nacionalidade: {Nacionalidade}");

        if (DataNascimento.HasValue)
        {
            Console.WriteLine($"Idade: {CalculaIdade()} anos");
        }
    }

    public int CalculaIdade()
    {
        if (DataNascimento.HasValue) 
        {
            return DateTime.Now.Year - DataNascimento.Value.Year;
        }

        return 0;
    }
}