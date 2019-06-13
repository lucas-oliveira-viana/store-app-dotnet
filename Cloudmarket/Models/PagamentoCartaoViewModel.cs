using System;
using System.ComponentModel.DataAnnotations;

namespace Cloudmarket.Web.Models
{
    public enum TipoCartao
    {
        [Display(Name = "Crédito")]
        CREDITO,
        [Display(Name = "Débito")]
        DEBITO
    }
    public class PagamentoCartaoViewModel
    {
        [Display(Name = "Tipo do Cartão")]
        public TipoCartao TipoCartao { get; set; }

        public string Numero { get; set; }

        [Display(Name = "Nome no Cartão")]
        public string NomeCartao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Validade { get; set; }

        public int Cvv { get; set; }
    }
}