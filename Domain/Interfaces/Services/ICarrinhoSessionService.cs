using Cloudmarket.Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface ICarrinhoSessionService : IServiceBase<CarrinhoSession>
    {
        List<CarrinhoSession> GetCarrinhoSessionByUsuarioId(string id);
    }
}
