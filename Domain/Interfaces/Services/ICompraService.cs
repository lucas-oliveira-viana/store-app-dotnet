using Cloudmarket.Domain.Entities;
using System.Collections;

namespace Domain.Interfaces.Services
{
    public interface ICompraService : IServiceBase<Compra>
    {
        ArrayList GetGetCincoPrimeirasComprasIdByUsuarioId(string usuarioId);
    }
}
