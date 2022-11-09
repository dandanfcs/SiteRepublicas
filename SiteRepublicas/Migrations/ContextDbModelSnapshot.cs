﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteRepublicas.DataContext;

namespace SiteRepublicas.Migrations
{
    [DbContext(typeof(ContextDb))]
    partial class ContextDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SiteRepublicas.Models.Republicas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Banheiros")
                        .HasColumnType("int");

                    b.Property<int>("Cozinha")
                        .HasColumnType("int");

                    b.Property<int>("Garagem")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero_de_Vagas")
                        .HasColumnType("int");

                    b.Property<int>("Quartos")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salas")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Republicas");
                });
#pragma warning restore 612, 618
        }
    }
}