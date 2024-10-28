﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SistemaVeicular.Infrastructure.DataAccess;

#nullable disable

namespace SistemaVeicular.Infrastructure.Migrations
{
    [DbContext(typeof(SistemaVeicularDbContext))]
    [Migration("20241022002203_SistemaVeicular")]
    partial class SistemaVeicular
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Observacao")
                        .HasColumnType("text");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.EmpresaColetora", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Servicos")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EmpresaColetora");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("ClienteId")
                        .HasColumnType("bigint");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("EmpresaColetoraId")
                        .HasColumnType("bigint");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("TecnicoMecanicoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.HasIndex("EmpresaColetoraId")
                        .IsUnique();

                    b.HasIndex("TecnicoMecanicoId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.Notificacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataNotificacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Enviada")
                        .HasColumnType("boolean");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("ServicoManutencaoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ServicoManutencaoId")
                        .IsUnique();

                    b.ToTable("Notificacao");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.ServicoManutencao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<double>("CustoManutencao")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DataReparo")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Garantia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomeProblema")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Quilometragem")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Relatorio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("TecnicoMecanicoId")
                        .HasColumnType("bigint");

                    b.Property<int>("Tipo")
                        .HasColumnType("integer");

                    b.Property<long>("VeiculoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TecnicoMecanicoId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Manutencoe");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.TecnicoMecanico", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Mecanico");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.Veiculo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("integer");

                    b.Property<int>("CilindradaMotor")
                        .HasColumnType("integer");

                    b.Property<long>("ClienteId")
                        .HasColumnType("bigint");

                    b.Property<int>("Cor")
                        .HasColumnType("integer");

                    b.Property<int>("Marca")
                        .HasColumnType("integer");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.Endereco", b =>
                {
                    b.HasOne("SistemaVeicular.Domain.Entities.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("SistemaVeicular.Domain.Entities.Endereco", "ClienteId");

                    b.HasOne("SistemaVeicular.Domain.Entities.EmpresaColetora", "EmpresaColetora")
                        .WithOne("Endereco")
                        .HasForeignKey("SistemaVeicular.Domain.Entities.Endereco", "EmpresaColetoraId");

                    b.HasOne("SistemaVeicular.Domain.Entities.TecnicoMecanico", "TecnicoMecanico")
                        .WithMany()
                        .HasForeignKey("TecnicoMecanicoId");

                    b.Navigation("Cliente");

                    b.Navigation("EmpresaColetora");

                    b.Navigation("TecnicoMecanico");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.Notificacao", b =>
                {
                    b.HasOne("SistemaVeicular.Domain.Entities.ServicoManutencao", "ServicoManutencao")
                        .WithOne("Notificacao")
                        .HasForeignKey("SistemaVeicular.Domain.Entities.Notificacao", "ServicoManutencaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServicoManutencao");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.ServicoManutencao", b =>
                {
                    b.HasOne("SistemaVeicular.Domain.Entities.TecnicoMecanico", "TecnicoMecanico")
                        .WithMany("ServiciosManutencao")
                        .HasForeignKey("TecnicoMecanicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaVeicular.Domain.Entities.Veiculo", "Veiculo")
                        .WithMany("ServicioManutencao")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TecnicoMecanico");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.Veiculo", b =>
                {
                    b.HasOne("SistemaVeicular.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Veiculos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.EmpresaColetora", b =>
                {
                    b.Navigation("Endereco")
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.ServicoManutencao", b =>
                {
                    b.Navigation("Notificacao")
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.TecnicoMecanico", b =>
                {
                    b.Navigation("ServiciosManutencao");
                });

            modelBuilder.Entity("SistemaVeicular.Domain.Entities.Veiculo", b =>
                {
                    b.Navigation("ServicioManutencao");
                });
#pragma warning restore 612, 618
        }
    }
}