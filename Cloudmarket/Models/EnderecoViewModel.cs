using System.ComponentModel.DataAnnotations;

namespace Cloudmarket.Web.Models
{
    public class EnderecoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "CEP")]
        public string Cep { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string UsuarioId { get; set; }
    }
}