using Cloudmarket.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Data.EntityConfig
{
    public class CompraConfiguration : EntityTypeConfiguration<Compra>
    {
        public CompraConfiguration()
        {
            HasMany(c => c.ProdutosCarrinho).WithRequired().HasForeignKey(pc => pc.CompraId);
        }
    }
}
