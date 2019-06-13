using Cloudmarket.Infra.Data.Repository;
using Cloudmarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cloudmarket.Service
{
    public class ProdutoService
    {
        ProdutoRepository produtoRepository = new ProdutoRepository();

        public List<string> getUmaCategoriaDeCada()
        {
            var todasAsCategorias = produtoRepository.getAllCategories();
            var umaCategoriaDeCada = todasAsCategorias.Distinct().ToList();
            return umaCategoriaDeCada;
        }

        public Produto getProdutoByCodigo(string codigo)
        {
            return produtoRepository.getProdutoByCodigo(codigo);
        }
    }
}