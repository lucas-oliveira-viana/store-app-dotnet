using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cloudmarket.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Rg { get; set; }

        public string CPF { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Marca { get; set; }

        public string Categoria { get; set; }

        public string Modelo { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public string ImagemPath { get; set; }

        public int QtdEstoque { get; set; }

        public int QtdVendida { get; set; }

    }

    public class Endereco
    {
        public int Id { get; set; }

        public string Cep { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string UsuarioId { get; set; }
    }

    public enum TiposPgto
    {
        [Display(Name = "Cartao")]
        CARTAO,
        [Display(Name = "Boleto")]
        BOLETO
    }

    public class Pagamento
    {
        public int Id { get; set; }

        public string UsuarioId { get; set; }

        [Display(Name = "Forma de Pagamento")]
        public TiposPgto Tipo { get; set; }

        public string InformacoesPagamento { get; set; }
    }

    public class Compra
    {
        public int Id { get; set; }

        public string UsuarioId { get; set; }

        public string EnderecoId { get; set; }

        public string PagamentoId { get; set; }

        public virtual ICollection<ProdutoCarrinho> ProdutosCarrinho { get; set; }
    }

    public class ProdutoCarrinho
    {
        public int Id  { get; set; }

        public int CompraId { get; set; }

        public virtual Compra Compra { get; set; }

        public int Quantidade { get; set; }

        public int ProdutoId { get; set; }
    }

    public class CarrinhoSession
    {
        public int Id { get; set; }

        public string UsuarioId { get; set; }

        public string CodigoProduto { get; set; }

        public int Quantidade { get; set; }

    }
}