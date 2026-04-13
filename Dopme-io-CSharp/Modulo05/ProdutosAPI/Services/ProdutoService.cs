// using System.Runtime.CompilerServices;
// using ValidacaoErros.Interfaces;
// using ValidacaoErros.Models;
//
// namespace ProdutosAPI.Services;
//
// public class ProdutoService : IProduto
// {
//     private readonly List<Produto> _produtos = new();
//     private static int _nextId = 1;
//     
//     public Produto Criar(Produto produto)
//     {
//         produto.Id = _nextId++;
//         _produtos.Add(produto);
//         return produto;
//     }
// }