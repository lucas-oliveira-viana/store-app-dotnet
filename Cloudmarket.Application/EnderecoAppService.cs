using System.Collections.Generic;
using Cloudmarket.Application.Interface;
using Cloudmarket.Domain.Entities;
using Domain.Interfaces.Services;

namespace Cloudmarket.Application
{
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService enderecoService) : base(enderecoService)
        {
            _enderecoService = enderecoService;
        }

        public Endereco GetUltimoEnderecoCadastrado(string usuarioId)
        {
            return _enderecoService.GetUltimoEnderecoCadastrado(usuarioId);
        }

        public List<string> NomesRua(int id_consultado)
        {
            return _enderecoService.NomesRua(id_consultado);
        }
    }
}
