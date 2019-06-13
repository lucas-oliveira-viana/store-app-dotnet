using Cloudmarket.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
        }
    }
}
