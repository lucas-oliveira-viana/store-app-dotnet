using Cloudmarket.Application.Interface;
using Cloudmarket.Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudmarket.Application
{
    public class CompraAppService : AppServiceBase<Compra>, ICompraAppService
    {
        private readonly ICompraService _compraService;

        public CompraAppService(ICompraService compraService) : base(compraService)
        {
            _compraService = compraService;
        }
    }
}
