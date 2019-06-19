using System.Collections.Generic;
using Cloudmarket.Domain.Entities;
using Cloudmarket.Domain.Interfaces;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _repo;

        public EnderecoService(IEnderecoRepository repo) : base(repo) => _repo = repo;

        public List<string> NomesRua(int id_consultado)
        {
            return _repo.NomesRua(id_consultado);
        }

        public Endereco GetUltimoEnderecoCadastrado(string usuarioId)
        {
            return _repo.GetUltimoEnderecoCadastrado(usuarioId);
        }
    }
}
