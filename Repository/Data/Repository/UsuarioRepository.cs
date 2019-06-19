using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Domain.Entities;
using Domain.Interfaces;
using System.Linq;

namespace Cloudmarket.Infra.Data.Repository
{
    public class UsuarioRepository : RepositoryBase<ApplicationUser>, IUsuarioRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ApplicationUser FindUsuarioById(string usuarioId)
        {
            return db.Users.Find(usuarioId);
        }

        public string FindNomeById(string usuarioId)
        {
            return db.Users.Find(usuarioId).Nome;
        }

        public string FindCpfById(string usuarioId)
        {
            return db.Users.Find(usuarioId).CPF;
        }

        public string FindRgById(string usuarioId)
        {
            return db.Users.Find(usuarioId).Rg;
        }
    }
}