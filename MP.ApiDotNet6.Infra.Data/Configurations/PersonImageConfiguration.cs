using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MP.ApiDotNet6.Domain.Entities;

namespace MP.ApiDotNet6.Infra.Data.Configurations {
    public class PersonImageConfiguration : IEntityTypeConfiguration<PersonImage> {
        public void Configure(EntityTypeBuilder<PersonImage> builder) {
            builder.ToTable("pessoaimagem");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("idimagem")
                .UseIdentityColumn();

            builder.Property(x => x.PersonId)
                .HasColumnName("idpessoa");

            builder.Property(x => x.ImageBase)
                    .HasColumnName("imagembase");

            builder.Property(x => x.ImageUri)
                .HasColumnName("imagemurl");

            builder.HasOne(x => x.Person)
                .WithMany(x => x.PersonImages);

        }
    }
}
