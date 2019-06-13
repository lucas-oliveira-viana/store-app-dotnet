using Cloudmarket.Infra.Data.Repository;
using Cloudmarket.Domain.Entities;
using System.Collections.Generic;

namespace Cloudmarket.Service
{
    public class CarrinhoSessionService
    {
        CarrinhoSessionRepository CarrinhoSessionRepository = new CarrinhoSessionRepository();

        public List<CarrinhoSession> GetCarrinhoSessionByUsuarioId(string usuarioId)
        {
            return CarrinhoSessionRepository.getCarrinhoSessionByUsuarioId(usuarioId);
        }
    }
}