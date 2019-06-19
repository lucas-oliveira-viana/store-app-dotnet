using Cloudmarket.Domain.Entities;
using System.Collections.Generic;

namespace Cloudmarket.Application.Interface
{
    public interface IEnderecoAppService : IAppServiceBase<Endereco>
    {
        List<string> NomesRua(int id_consultado);

        Endereco GetUltimoEnderecoCadastrado(string usuarioId);
    }
}
