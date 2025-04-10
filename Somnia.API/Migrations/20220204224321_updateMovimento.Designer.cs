﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Somnia.API.Data;

namespace Somnia.API.Migrations
{
    [DbContext(typeof(SomniaContext))]
    [Migration("20220204224321_updateMovimento")]
    partial class updateMovimento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Somnia.API.Models.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Somnia.API.Models.Conta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ContaPaiID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.HasIndex("ContaPaiID");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("Somnia.API.Models.Movimento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ContaDestinoID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContaID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacao")
                        .HasColumnType("TEXT");

                    b.Property<int>("OperacaoID")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.HasIndex("ContaDestinoID");

                    b.HasIndex("ContaID");

                    b.HasIndex("OperacaoID");

                    b.ToTable("Movimentos");
                });

            modelBuilder.Entity("Somnia.API.Models.Operacao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Recorrente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Operacoes");
                });

            modelBuilder.Entity("Somnia.API.Models.Saldo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Acumulado")
                        .HasColumnType("REAL");

                    b.Property<int>("ContaID")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Credito")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataSaldo")
                        .HasColumnType("TEXT");

                    b.Property<double>("Debito")
                        .HasColumnType("REAL");

                    b.Property<double>("Dividendos")
                        .HasColumnType("REAL");

                    b.Property<double>("Entrada")
                        .HasColumnType("REAL");

                    b.Property<double>("Rendimento")
                        .HasColumnType("REAL");

                    b.Property<double>("Saida")
                        .HasColumnType("REAL");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.Property<double>("Valorizacao")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.HasIndex("ContaID");

                    b.ToTable("Saldos");
                });

            modelBuilder.Entity("Somnia.API.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DataAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(2022, 2, 4, 19, 43, 20, 630, DateTimeKind.Local).AddTicks(3617),
                            Login = "admin",
                            Name = "Admin",
                            Password = "pgadmin",
                            Role = ""
                        });
                });

            modelBuilder.Entity("Somnia.API.Models.Conta", b =>
                {
                    b.HasOne("Somnia.API.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Somnia.API.Models.Conta", "ContaPai")
                        .WithMany()
                        .HasForeignKey("ContaPaiID");

                    b.Navigation("Categoria");

                    b.Navigation("ContaPai");
                });

            modelBuilder.Entity("Somnia.API.Models.Movimento", b =>
                {
                    b.HasOne("Somnia.API.Models.Conta", "ContaDestino")
                        .WithMany()
                        .HasForeignKey("ContaDestinoID");

                    b.HasOne("Somnia.API.Models.Conta", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Somnia.API.Models.Operacao", "Operacao")
                        .WithMany()
                        .HasForeignKey("OperacaoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conta");

                    b.Navigation("ContaDestino");

                    b.Navigation("Operacao");
                });

            modelBuilder.Entity("Somnia.API.Models.Operacao", b =>
                {
                    b.HasOne("Somnia.API.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Somnia.API.Models.Saldo", b =>
                {
                    b.HasOne("Somnia.API.Models.Conta", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conta");
                });
#pragma warning restore 612, 618
        }
    }
}
