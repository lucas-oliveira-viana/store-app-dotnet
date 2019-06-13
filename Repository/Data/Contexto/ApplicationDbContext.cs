using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using Cloudmarket.Domain.Entities;
using Repository.Data.EntityConfig;

namespace Cloudmarket.Infra.Data.Contexto
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CompraConfiguration());
            modelBuilder.Configurations.Add(new ProdutoCarrinhoConfiguration());
        }

        public System.Data.Entity.DbSet<Produto> Produtos { get; set; }
        public object Produto { get; internal set; }

        public System.Data.Entity.DbSet<Endereco> Enderecos { get; set; }
        public object Endereco { get; internal set; }

        public System.Data.Entity.DbSet<Pagamento> Pagamentos { get; set; }
        public object Pagamento { get; internal set; }

        public System.Data.Entity.DbSet<Compra> Compras { get; set; }
        public object Compra { get; internal set; }

        public System.Data.Entity.DbSet<ProdutoCarrinho> ProdutosCarrinho { get; set; }
        public object ProdutoCarrinho { get; set; }

        public System.Data.Entity.DbSet<CarrinhoSession> CarrinhoSessions { get; set; }
        public object CarrinhoSession { get; internal set; }
    }
}
