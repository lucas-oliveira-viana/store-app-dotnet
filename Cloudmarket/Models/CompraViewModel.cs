using Cloudmarket.Domain.Entities;
using System.Collections.Generic;

namespace Cloudmarket.Web.Models
{
    public class CompraViewModel
    {
        public int Id { get; set; }

        public string UsuarioId { get; set; }

        public string EnderecoId { get; set; }

        public string PagamentoId { get; set; }

        public ICollection<ProdutoCarrinho> ProdutosCarrinho { get; set; }
    }
}