using System.Collections.Generic;
using Cloudmarket.Application.Interface;
using Cloudmarket.Domain.Entities;
using Domain.Interfaces.Services;

namespace Cloudmarket.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public Produto GetProdutoByCodigo(string codigo)
        {
            return _produtoService.GetProdutoByCodigo(codigo);
        }

        public List<string> GetUmaCategoriaDeCada()
        {
            return _produtoService.GetUmaCategoriaDeCada();
        }
    }
}
