using System.ComponentModel.DataAnnotations;

namespace Cloudmarket.Web.Models
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Marca { get; set; }

        public string Categoria { get; set; }

        public string Modelo { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

        [Display(Name = "URL da Imagem")]
        public string ImagemPath { get; set; }

        public int QtdEstoque { get; set; }

        public int QtdVendida { get; set; }

    }
}