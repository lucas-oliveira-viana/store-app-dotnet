using Cloudmarket.Domain.Entities;
using Cloudmarket.Domain.Interfaces;

namespace Domain.Interfaces
{
    public interface IPagamentoRepository : IRepositoryBase<Pagamento>
    {
        Pagamento GetUltimoCartaoCadastrado(string usuarioId);
    }
}
