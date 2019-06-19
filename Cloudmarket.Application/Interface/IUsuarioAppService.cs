using Cloudmarket.Domain.Entities;

namespace Cloudmarket.Application.Interface
{
    public interface IUsuarioAppService : IAppServiceBase<ApplicationUser>
    {
        ApplicationUser FindUsuarioById(string id_usuario);

        string FindNomeById(string id_usuario);

        string FindCpfById(string usuarioId);

        string FindRgById(string usuarioId);
    }
}
