using Cloudmarket.Domain.Entities;
using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Infra.Data.Repository;
using Domain.Interfaces;
using System.Linq;

namespace Repository.Data.Repository
{
    public class PagamentoRepository : RepositoryBase<Pagamento>, IPagamentoRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public Pagamento GetUltimoCartaoCadastrado(string usuarioId)
        {
            return db.Pagamentos.Where(e => e.UsuarioId == usuarioId && e.Tipo == 0).First();
        }
    }
}
