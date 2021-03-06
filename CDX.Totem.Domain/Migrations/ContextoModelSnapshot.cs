﻿// <auto-generated />
using System;
using CDX.Totem.Domain.Infraestrutura.Conexao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CDX.Totem.Domain.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CDX.Totem.Domain.Models.LogEvento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedTime");

                    b.Property<int?>("EventId");

                    b.Property<string>("LogLevel");

                    b.Property<string>("Message");

                    b.HasKey("Id");

                    b.ToTable("LogEvento");
                });

            modelBuilder.Entity("CDX.Totem.Domain.Models.TotemConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AtendeDetran");

                    b.Property<bool>("AtendePatios");

                    b.Property<string>("ChaveAcessoSinPag")
                        .HasMaxLength(20);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Contratante")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime?>("DataCadastro");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Estabelecimento")
                        .HasMaxLength(20);

                    b.Property<int>("FusoHorario");

                    b.Property<string>("InformativoH1")
                        .HasMaxLength(80);

                    b.Property<string>("InformativoH2")
                        .HasMaxLength(80);

                    b.Property<string>("InformativoH3")
                        .HasMaxLength(80);

                    b.Property<int>("LimiteInatividade");

                    b.Property<bool>("Logado");

                    b.Property<string>("Logotipo")
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.Property<string>("ProgressBarTextoH1")
                        .HasMaxLength(80);

                    b.Property<string>("ProgressBarTextoH2")
                        .HasMaxLength(80);

                    b.Property<string>("Serial")
                        .HasMaxLength(50);

                    b.Property<int>("Situacao");

                    b.Property<int?>("UsuarioId");

                    b.Property<string>("Versao")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("TotemConfig");
                });
#pragma warning restore 612, 618
        }
    }
}
