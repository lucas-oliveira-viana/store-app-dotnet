using Cloudmarket.Domain.Entities;
using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Infra.Data.Repository;
using Domain.Interfaces;
using System.Collections;
using System.Linq;

namespace Repository.Data.Repository
{
    public class CompraRepository : RepositoryBase<Compra>, ICompraRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ArrayList GetCincoPrimeirasComprasIdByUsuarioId(string usuarioId)
        {
            var compras = db.Compras.Where(c => c.UsuarioId == usuarioId).Take(5).ToList();

            ArrayList comprasId = new ArrayList();

            foreach (var compra in compras)
            {
                comprasId.Add(compra.Id);
            }

            return comprasId;
        }
    }
}
