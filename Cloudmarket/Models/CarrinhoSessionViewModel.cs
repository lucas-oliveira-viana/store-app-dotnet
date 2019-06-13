using System.ComponentModel.DataAnnotations;

namespace Cloudmarket.Models
{
    public class CarrinhoSessionViewModel
    {
        [Key]
        public int Id { get; set; }

        public string UsuarioId { get; set; }

        public string CodigoProduto { get; set; }

        public int Quantidade { get; set; }
    }
}