using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Domain.Entities;
using Domain.Interfaces;

namespace Cloudmarket.Infra.Data.Repository
{
    public class UsuarioRepository : RepositoryBase<ApplicationUser>, IUsuarioRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ApplicationUser FindUsuarioById(string id_usuario)
        {
            return db.Users.Find(id_usuario);
        }

        public string FindNomeById(string id_usuario)
        {
            return db.Users.Find(id_usuario).Nome;
        }
    }
}