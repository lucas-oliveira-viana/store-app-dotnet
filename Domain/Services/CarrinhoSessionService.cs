using Cloudmarket.Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Domain.Services
{
    public class CarrinhoSessionService : ServiceBase<CarrinhoSession>, ICarrinhoSessionService
    {
        private readonly ICarrinhoSessionRepository _repo;

        public CarrinhoSessionService(ICarrinhoSessionRepository repo) : base(repo) => _repo = repo;

        public List<CarrinhoSession> GetCarrinhoSessionByUsuarioId(string id)
        {
            return _repo.GetCarrinhoSessionByUsuarioId(id);
        }
    }
}
