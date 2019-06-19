using Cloudmarket.Domain.Entities;
using Cloudmarket.Domain.Interfaces;
using Cloudmarket.Infra.Data.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace Cloudmarket.Infra.Data.Repository
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public List<string> NomesRua(int id_consultado)
        {
            var ruas = new List<string>();

            var enderecosBanco = db.Enderecos.Where(e => e.Id == id_consultado);
            foreach (var endereco in enderecosBanco)
            {
                ruas.Add(endereco.Rua);
            }
            return ruas;
        }

        public Endereco GetUltimoEnderecoCadastrado(string usuarioId)
        {
            return db.Enderecos.Where(e => e.UsuarioId == usuarioId).First();
        }
    }
}