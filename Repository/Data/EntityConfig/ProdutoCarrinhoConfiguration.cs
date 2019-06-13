using Cloudmarket.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Data.EntityConfig
{
    class ProdutoCarrinhoConfiguration : EntityTypeConfiguration<ProdutoCarrinho>
    {
        public ProdutoCarrinhoConfiguration()
        {
            HasKey(pc => pc.Id);
        }
    }
}
