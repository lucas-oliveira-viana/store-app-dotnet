using Cloudmarket.Domain.Entities;
using Cloudmarket.Domain.Interfaces;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        List<string> GetUmaCategoriaDeCada();

        Produto GetProdutoByCodigo(string codigo);
    }
}
