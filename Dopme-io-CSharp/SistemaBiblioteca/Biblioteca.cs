namespace SistemaBiblioteca;

public class Biblioteca
{
    public string Nome { get; set; }
    public List<Livro> Livros = new();
    public List<Autor> Autores = new();
    public List<Emprestimo> Emprestimos = new();

    public Biblioteca(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAutor(Autor autor)
    {
        Autores.Add(autor);
        Console.WriteLine($"Autor {autor.Nome} cadastrado");
    }

    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"✅ Livro '{livro.Titulo}' adicionado");
    }

    public Livro BuscarLivroPorISBN(string isbn)
    {
        return Livros.FirstOrDefault(l => l.ISBN == isbn);
    }

    public List<Livro> BuscarLivrosPorAutor(string nomeAutor)
    {
        return Livros.Where(l => l.Autor.Nome.ToLower() ==
                                 nomeAutor.ToLower()).ToList();
    }

    public void EmprestarLivro(string isbn, string nomePessoa)
    {
        var livro = BuscarLivroPorISBN(isbn);
        if (livro == null)
        {
            Console.WriteLine("❌ Livro não encontrado");
            return;
        }

        if (!livro.Disponivel)
        {
            Console.WriteLine("❌ Livro não está disponível");
            return;
        }

        var emprestimo = new Emprestimo(livro, nomePessoa);
        Emprestimos.Add(emprestimo);
        livro.Emprestar();
    }

    public void DevolverLivro(string isbn)
    {
        var emprestimo = Emprestimos
            .Where(e => e.Livro.ISBN == isbn && !e.Devolvido)
            .FirstOrDefault();

        if (emprestimo == null)
        {
            Console.WriteLine("❌ Empréstimo não encontrado");
            return;
        }

        emprestimo.RegistrarDevolucao();
    }
}