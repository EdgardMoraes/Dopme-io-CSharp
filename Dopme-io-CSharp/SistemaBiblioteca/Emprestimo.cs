namespace SistemaBiblioteca;

public class Emprestimo
{
    public Livro Livro { get; set; }
    public string NomePessoa { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucaoEsperada { get; set; }
    public DateTime? DataDevolucaoReal { get; set; }
    public bool Devolvido { get; set; }

    public Emprestimo(Livro livro, string nomePessoa, int diasEmprestimos = 14)
    {
        Livro = livro;
        NomePessoa = nomePessoa;
        DataEmprestimo = DateTime.Now;
        DataDevolucaoEsperada = DataEmprestimo.AddDays(diasEmprestimos);
    }

    public void RegistrarDevolucao()
    {
        DataDevolucaoReal = DateTime.Now;
        Livro.Devolver();
    }

    public bool Atrasado()
    {
        if (Devolvido)

            return DataDevolucaoReal.Value > DataDevolucaoEsperada;
        else
            return DateTime.Now > DataDevolucaoEsperada;
    }

    public int DiasAtrasado()
    {
        if (!Atrasado())
            return 0;
        DateTime dataConsideracao = Devolvido ? DataDevolucaoReal.Value : DateTime.Now;
        TimeSpan diferenca = dataConsideracao - DataDevolucaoEsperada;
        return (int)diferenca.TotalDays;
    }

    public void Exibir()
    {
        string status = Devolvido ? "✅ Devolvido" : "⏳ Ativo";
        Console.WriteLine($"📚 Empréstimo: {Livro.Titulo}");
        Console.WriteLine($" Para: {NomePessoa}");
        Console.WriteLine($" Data: {DataEmprestimo:dd/MM/yyyy}");
        Console.WriteLine($" Devolução esperada:{DataDevolucaoEsperada:dd/MM/yyyy}");
        if (Devolvido)
            Console.WriteLine($" Devolvido em: {DataDevolucaoReal:dd/MM/yyyy}");
        Console.WriteLine($" Status: {status}");
        if (Atrasado())
            Console.WriteLine($" ⚠ ATRASADO! {DiasAtrasado()} dias");
    }
}