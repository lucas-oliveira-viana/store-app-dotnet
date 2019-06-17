using System.Collections.Generic;
using Cloudmarket.Domain.Entities;
using Domain.Interfaces.Services;

namespace Cloudmarket.Application.Interface
{
    public class CarrinhoSessionAppService : AppServiceBase<CarrinhoSession>, ICarrinhoSessionAppService
    {
        private readonly ICarrinhoSessionService _csService;

        public CarrinhoSessionAppService(ICarrinhoSessionService csService) : base(csService)
        {
            _csService = csService;
        }

        public List<CarrinhoSession> GetCarrinhoSessionByUsuarioId(string id)
        {
            return _csService.GetCarrinhoSessionByUsuarioId(id);
        }
    }
}
