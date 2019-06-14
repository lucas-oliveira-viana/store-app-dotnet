using Cloudmarket.Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface IEnderecoService : IServiceBase<Endereco>
    {
        List<string> NomesRua(int id_consultado);
    }
}
