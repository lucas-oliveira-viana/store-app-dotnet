using Cloudmarket.Infra.Data.Contexto;
using Cloudmarket.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces;

namespace Cloudmarket.Infra.Data.Repository
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public List<string> GetUmaCategoriaDeCada()
        {
            var todasCategoriasCadastradas = db.Produtos.Select(produto => produto.Categoria).ToList();
            return todasCategoriasCadastradas;
        }

        public Produto GetProdutoByCodigo(string codigo)
        {
            var produto = db.Produtos.Where(prod => prod.Codigo == codigo).ToList();
            return produto.First();
        }
    }
}