using Cloudmarket.Domain.Entities;
using Cloudmarket.Domain.Interfaces;
using Cloudmarket.Infra.Data.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace Cloudmarket.Infra.Data.Repository
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public static List<string> nomesRua(int id_consultado)
        {
            var ruas = new List<string>();
            using (ApplicationDbContext db = new ApplicationDbContext()) {
                var enderecosBanco = db.Enderecos.Where(e => e.Id == id_consultado);
                foreach (var endereco in enderecosBanco)
                {
                    ruas.Add(endereco.Rua);
                }
            }
            return ruas;
        }
    }
}