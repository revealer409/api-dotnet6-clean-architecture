using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MP.ApiDotNet6.Domain.Entities;

namespace MP.ApiDotNet6.Infra.Data.Configurations {
    public class ProductConfiguration : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {
            builder.ToTable("Produto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("Idproduto")
                .UseIdentityColumn();

            builder.Property(p => p.CodErp)
                .HasColumnName("Coderp");

            builder.Property(p => p.Name)
                .HasColumnName("Nome");

            builder.Property(p => p.Price)
                .HasColumnName("Preco");

            builder.HasMany(c => c.Purchases)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.ProductId);

        }
    }
}
