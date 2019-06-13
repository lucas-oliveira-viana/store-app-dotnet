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

        public List<string> getAllCategories()
        {
            var todasCategoriasCadastradas = db.Produtos.Select(produto => produto.Categoria).ToList();
            return todasCategoriasCadastradas;
        }

        public Produto getProdutoByCodigo(string codigo)
        {
            var produto = db.Produtos.Where(prod => prod.Codigo == codigo).ToList();
            return produto.First();
        }
    }
}