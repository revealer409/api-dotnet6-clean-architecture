﻿// <auto-generated />
using System;
using MP.ApiDotNet6.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MP.ApiDotNet6.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MP.ApiDotNet6.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Idpessoa");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Documento");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Nome");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Celular");

                    b.HasKey("Id");

                    b.ToTable("Pessoa", (string)null);
                });

            modelBuilder.Entity("MP.ApiDotNet6.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Idproduto");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodErp")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Coderp");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Nome");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("Preco");

                    b.HasKey("Id");

                    b.ToTable("Produto", (string)null);
                });

            modelBuilder.Entity("MP.ApiDotNet6.Domain.Entities.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idcompra");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("date")
                        .HasColumnName("datacompra");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer")
                        .HasColumnName("idpessoa");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("Idproduto");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("ProductId");

                    b.ToTable("compra", (string)null);
                });

            modelBuilder.Entity("MP.ApiDotNet6.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idusuario");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("senha");

                    b.HasKey("Id");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("MP.ApiDotNet6.Domain.Entities.Purchase", b =>
                {
                    b.HasOne("MP.ApiDotNet6.Domain.Entities.Person", "Person")
                        .WithMany("Purchases")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MP.ApiDotNet6.Domain.Entities.Product", "Product")
                        .WithMany("Purchases")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MP.ApiDotNet6.Domain.Entities.Person", b =>
                {
                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("MP.ApiDotNet6.Domain.Entities.Product", b =>
                {
                    b.Navigation("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}
