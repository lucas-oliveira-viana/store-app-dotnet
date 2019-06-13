using Cloudmarket.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Cloudmarket.Web.Models
{
    public class PagamentoViewModel
    {
        public int Id { get; set; }

        public string UsuarioId { get; set; }

        [Display(Name = "Forma de Pagamento")]
        public TiposPgto Tipo { get; set; }

        public string InformacoesPagamento { get; set; }
    }
}