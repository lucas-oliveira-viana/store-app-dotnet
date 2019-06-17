using Cloudmarket.Domain.Entities;
using Cloudmarket.Domain.Interfaces;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ICarrinhoSessionRepository :  IRepositoryBase<CarrinhoSession>
    {
        List<CarrinhoSession> GetCarrinhoSessionByUsuarioId(string id);
    }
}
