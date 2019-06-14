using Cloudmarket.Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ProdutoCarrinhoService : ServiceBase<ProdutoCarrinho>, IProdutoCarrinhoService
    {
        private readonly IProdutoCarrinhoRepository _repo;

        public ProdutoCarrinhoService(IProdutoCarrinhoRepository repo) : base(repo) => _repo = repo;
    }
}
