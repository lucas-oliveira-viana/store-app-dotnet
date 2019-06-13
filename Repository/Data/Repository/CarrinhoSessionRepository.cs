using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces;

namespace Cloudmarket.Infra.Data.Repository
{
    public class CarrinhoSessionRepository : RepositoryBase<CarrinhoSession>, ICarrinhoSessionRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public List<CarrinhoSession> getCarrinhoSessionByUsuarioId(string usuarioId)
        {
            var carrinho = db.CarrinhoSessions.Where(carr => carr.UsuarioId == usuarioId).ToList();
            return carrinho;
        }
    }
}