using Cloudmarket.Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class CompraService : ServiceBase<Compra>, ICompraService
    {
        private readonly ICompraRepository _repo;

        public CompraService(ICompraRepository repo) : base(repo) => _repo = repo;
    }
}
