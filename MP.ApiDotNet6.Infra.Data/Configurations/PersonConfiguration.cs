using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MP.ApiDotNet6.Domain.Entities;

namespace MP.ApiDotNet6.Infra.Data.Configurations {
    public class PersonConfiguration : IEntityTypeConfiguration<Person> {

        public void Configure(EntityTypeBuilder<Person> builder) {
            builder.ToTable("Pessoa");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("Idpessoa")
                .UseIdentityColumn();

            builder.Property(p => p.Name)
                .HasColumnName("Nome");

            builder.Property(p => p.Document)
                .HasColumnName("Documento");

            builder.Property(p => p.Phone)
                .HasColumnName("Celular");

            builder.HasMany(c => c.Purchases)
                .WithOne(p => p.Person)
                .HasForeignKey(p => p.PersonId);

            builder.HasMany(c => c.PersonImages)
                .WithOne(p => p.Person)
                .HasForeignKey(x => x.PersonId);
        
        }

    }
}
