using Cloudmarket.Domain.Entities;
using Cloudmarket.Domain.Interfaces;
using System.Collections;

namespace Domain.Interfaces
{
    public interface ICompraRepository : IRepositoryBase<Compra>
    {
        ArrayList GetCincoPrimeirasComprasIdByUsuarioId(string usuarioId);
    }
}