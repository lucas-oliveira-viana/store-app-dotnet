using Cloudmarket.Application.Interface;
using Cloudmarket.Domain.Entities;
using Domain.Interfaces.Services;

namespace Cloudmarket.Application
{
    public class UsuarioAppService : AppServiceBase<ApplicationUser>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService) : base(usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public string FindNomeById(string id_usuario)
        {
            return _usuarioService.FindNomeById(id_usuario);
        }

        public ApplicationUser FindUsuarioById(string id_usuario)
        {
            return _usuarioService.FindUsuarioById(id_usuario);
        }
    }
}
