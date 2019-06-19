using Cloudmarket.Domain.Entities;
using System.Collections.Generic;

namespace Cloudmarket.Domain.Interfaces
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco>
    {
        List<string> NomesRua(int id_consultado);

        Endereco GetUltimoEnderecoCadastrado(string usuarioId);
    }
}
