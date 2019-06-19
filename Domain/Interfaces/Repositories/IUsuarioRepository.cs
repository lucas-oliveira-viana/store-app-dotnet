using Cloudmarket.Domain.Entities;
using Cloudmarket.Domain.Interfaces;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository : IRepositoryBase<ApplicationUser>
    {
        ApplicationUser FindUsuarioById(string usuarioId);

        string FindNomeById(string usuarioId);

        string FindCpfById(string usuarioId);

        string FindRgById(string usuarioId);
    }
}
