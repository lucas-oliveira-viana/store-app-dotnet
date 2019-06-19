using Cloudmarket.Domain.Entities;
using System.Collections;

namespace Cloudmarket.Application.Interface
{
    public interface ICompraAppService : IAppServiceBase<Compra>
    {
        ArrayList GetGetCincoPrimeirasComprasIdByUsuarioId(string usuarioId);
    }
}
