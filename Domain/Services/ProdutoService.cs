using System.Collections.Generic;
using Cloudmarket.Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _repo;

        public ProdutoService(IProdutoRepository repo) : base(repo) => _repo = repo;

        public Produto GetProdutoByCodigo(string codigo)
        {
            return _repo.GetProdutoByCodigo(codigo);
        }

        public List<string> GetUmaCategoriaDeCada()
        {
            return _repo.GetUmaCategoriaDeCada();
        }
    }
}
