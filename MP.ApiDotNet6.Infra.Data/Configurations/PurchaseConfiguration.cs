using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MP.ApiDotNet6.Domain.Entities;

namespace MP.ApiDotNet6.Infra.Data.Configurations {
    public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase> {
        public void Configure(EntityTypeBuilder<Purchase> builder) {
            builder.ToTable("compra");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("idcompra")
                .UseIdentityColumn();

            builder.Property(c => c.PersonId)
                .HasColumnName("idpessoa");

            builder.Property(c => c.ProductId)
                .HasColumnName("Idproduto");

            builder.Property(c => c.Date)
                .HasColumnType("date")
                .HasColumnName("datacompra");

            builder.HasOne(p => p.Person)
                .WithMany(c => c.Purchases);

            builder.HasOne(p => p.Product)
                .WithMany(c => c.Purchases);
        }
    }
}
