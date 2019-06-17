using Cloudmarket.Domain.Entities;
using System.Collections.Generic;

namespace Cloudmarket.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        List<string> GetUmaCategoriaDeCada();

        Produto GetProdutoByCodigo(string codigo);
    }
}