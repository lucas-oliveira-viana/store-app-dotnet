using Cloudmarket.Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<ApplicationUser>
    {
        ApplicationUser FindUsuarioById(string id_usuario);

        string FindNomeById(string id_usuario);
    }
}
