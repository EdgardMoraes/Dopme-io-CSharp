using Modulo05.ValidacaoErros.Exceptions;
using Modulo05.ValidacaoErros.Interfaces;
using Modulo05.ValidacaoErros.Models;

namespace Modulo05.ValidacaoErros.Services;

public class ProdutoService : IProduto
{
    private readonly List<Produto> _produtos = new();
    private static int _nextId = 1;
    
    public Produto Criar(Produto produto)
    {
        if (produto == null)
        {
            throw new ExcessaoNaoEncontrada($"O nome do produto não pode ser nulo");
        }
        produto.Id = _nextId++;
        _produtos.Add(produto);
        return produto;
    }
}