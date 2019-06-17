using Cloudmarket.Domain.Entities;
using System.Collections.Generic;

namespace Cloudmarket.Application.Interface
{
    public interface ICarrinhoSessionAppService : IAppServiceBase<CarrinhoSession>
    {
        List<CarrinhoSession> GetCarrinhoSessionByUsuarioId(string id);
    }
}
