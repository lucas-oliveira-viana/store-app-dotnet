using Cloudmarket.Domain.Entities;
using Cloudmarket.Domain.Interfaces;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository : IRepositoryBase<ApplicationUser>
    {
        ApplicationUser FindUsuarioById(string id_usuario);

        string FindNomeById(string id_usuario);
    }
}
