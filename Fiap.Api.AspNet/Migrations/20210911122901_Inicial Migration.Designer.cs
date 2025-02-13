﻿// <auto-generated />
using System;
using Fiap.Api.AspNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiap.Api.AspNet.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210911122901_Inicial Migration")]
    partial class InicialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiap.Api.AspNet.Model.UsuarioModel", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Regra")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UsuarioId");

                    b.ToTable("FiapUsuario");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            NomeUsuario = "Admin Senior",
                            Regra = "Senior",
                            Senha = "123456"
                        },
                        new
                        {
                            UsuarioId = 2,
                            NomeUsuario = "Admin Pleno",
                            Regra = "Pleno",
                            Senha = "123456"
                        },
                        new
                        {
                            UsuarioId = 3,
                            NomeUsuario = "Admin Junior",
                            Regra = "Junior",
                            Senha = "123456"
                        });
                });

            modelBuilder.Entity("Fiap.Api.AspNet.Models.CategoriaModel", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoriaId");

                    b.ToTable("FiapCategoria");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            NomeCategoria = "Smartphone"
                        },
                        new
                        {
                            CategoriaId = 2,
                            NomeCategoria = "Televisor"
                        },
                        new
                        {
                            CategoriaId = 3,
                            NomeCategoria = "Notebook"
                        },
                        new
                        {
                            CategoriaId = 4,
                            NomeCategoria = "Tablet"
                        });
                });

            modelBuilder.Entity("Fiap.Api.AspNet.Models.MarcaModel", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeMarca")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("MarcaId");

                    b.ToTable("FiapMarca");

                    b.HasData(
                        new
                        {
                            MarcaId = 1,
                            NomeMarca = "Apple"
                        },
                        new
                        {
                            MarcaId = 2,
                            NomeMarca = "Samsung"
                        },
                        new
                        {
                            MarcaId = 3,
                            NomeMarca = "Google"
                        },
                        new
                        {
                            MarcaId = 4,
                            NomeMarca = "Xiaomi"
                        });
                });

            modelBuilder.Entity("Fiap.Api.AspNet.Models.ProdutoModel", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caracteristicas")
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MarcaId");

                    b.ToTable("FiapProduto");

                    b.HasData(
                        new
                        {
                            ProdutoId = 1,
                            Caracteristicas = "",
                            CategoriaId = 1,
                            DataLancamento = new DateTime(2021, 9, 11, 9, 29, 0, 472, DateTimeKind.Local).AddTicks(1241),
                            Descricao = "Apple iPhone 12",
                            MarcaId = 1,
                            Nome = "iPhone 12",
                            Preco = 5000m,
                            Sku = "SKUIPH12"
                        });
                });

            modelBuilder.Entity("Fiap.Api.AspNet.Models.ProdutoModel", b =>
                {
                    b.HasOne("Fiap.Api.AspNet.Models.CategoriaModel", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Api.AspNet.Models.MarcaModel", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Marca");
                });
#pragma warning restore 612, 618
        }
    }
}
