using Cloudmarket.Domain.Entities;

namespace Cloudmarket.Application.Interface
{
    public interface IPagamentoAppService : IAppServiceBase<Pagamento>
    {
        Pagamento GetUltimoCartaoCadastrado(string usuarioId);
    }
}
