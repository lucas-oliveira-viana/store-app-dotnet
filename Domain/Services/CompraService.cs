using Cloudmarket.Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using System.Collections;

namespace Domain.Services
{
    public class CompraService : ServiceBase<Compra>, ICompraService
    {
        private readonly ICompraRepository _repo;

        public CompraService(ICompraRepository repo) : base(repo) => _repo = repo;

        public ArrayList GetGetCincoPrimeirasComprasIdByUsuarioId(string usuarioId)
        {
            return _repo.GetCincoPrimeirasComprasIdByUsuarioId(usuarioId);
        }
    }
}
