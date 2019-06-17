using Cloudmarket.Domain.Entities;
using Domain.Interfaces.Services;

namespace Cloudmarket.Application.Interface
{
    public class PagamentoAppService : AppServiceBase<Pagamento>, IPagamentoAppService
    {
        private readonly IPagamentoService _pagamentoService;

        public PagamentoAppService(IPagamentoService pagamentoService) : base(pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }
    }
}
