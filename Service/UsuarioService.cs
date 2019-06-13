using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cloudmarket.Infra.Data.Repository;
using Cloudmarket.Domain.Entities;

namespace Cloudmarket.Service
{
    public class UsuarioService
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();

        public string FindNomeById(string id_usuario)
        {
            return usuarioRepository.FindNomeById(id_usuario);
        }

        public ApplicationUser FindUsuarioById(string id_usuario)
        {
            return usuarioRepository.FindUsuarioById(id_usuario);
        }
    }
}