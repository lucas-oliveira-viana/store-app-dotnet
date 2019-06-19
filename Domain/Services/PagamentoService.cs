using Cloudmarket.Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Services;

namespace Cloudmarkt.Domain.Services
{
    public class PagamentoService : ServiceBase<Pagamento>, IPagamentoService
    {
        private readonly IPagamentoRepository _repo;

        public PagamentoService(IPagamentoRepository repo) : base(repo) => _repo = repo;

        public Pagamento GetUltimoCartaoCadastrado(string usuarioId)
        {
            return _repo.GetUltimoCartaoCadastrado(usuarioId);
        }
    }
}
