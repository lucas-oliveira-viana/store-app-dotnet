using Cloudmarket.Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class UsuarioService : ServiceBase<ApplicationUser>, IUsuarioService
    {
        private readonly IUsuarioRepository _repo;

        public UsuarioService(IUsuarioRepository repo) : base(repo) => _repo = repo;

        public string FindNomeById(string id_usuario)
        {
            return _repo.FindNomeById(id_usuario);
        }

        public ApplicationUser FindUsuarioById(string id_usuario)
        {
            return FindUsuarioById(id_usuario);
        }
    }
}
