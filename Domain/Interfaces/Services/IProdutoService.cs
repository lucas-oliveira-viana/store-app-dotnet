using Cloudmarket.Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        List<string> GetUmaCategoriaDeCada();

        Produto GetProdutoByCodigo(string codigo);
    }
}
