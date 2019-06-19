using Cloudmarket.Application.Interface;
using Cloudmarket.Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections;

namespace Cloudmarket.Application
{
    public class CompraAppService : AppServiceBase<Compra>, ICompraAppService
    {
        private readonly ICompraService _compraService;

        public CompraAppService(ICompraService compraService) : base(compraService)
        {
            _compraService = compraService;
        }

        public ArrayList GetGetCincoPrimeirasComprasIdByUsuarioId(string usuarioId)
        {
            return _compraService.GetGetCincoPrimeirasComprasIdByUsuarioId(usuarioId);
        }
    }
}
