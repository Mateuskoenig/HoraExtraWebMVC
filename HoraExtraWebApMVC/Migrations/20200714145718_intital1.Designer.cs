﻿// <auto-generated />
using System;
using HoraExtraWebApMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HoraExtraWebApMVC.Migrations
{
    [DbContext(typeof(HoraExtraWebApMVCContext))]
    [Migration("20200714145718_intital1")]
    partial class intital1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HoraExtraWebApMVC.Models.Departamento.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Gestor");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("HoraExtraWebApMVC.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Decricao");

                    b.Property<int?>("DepartamentoId");

                    b.Property<DateTime>("DiaDaHoraExtra");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("HoraExtraWebApMVC.Models.HorasExtra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("DataDaHora");

                    b.Property<int?>("FuncionarioId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("HorasExtra");
                });

            modelBuilder.Entity("HoraExtraWebApMVC.Models.Funcionario", b =>
                {
                    b.HasOne("HoraExtraWebApMVC.Models.Departamento.Departamento", "Departamento")
                        .WithMany("Funcionarios")
                        .HasForeignKey("DepartamentoId");
                });

            modelBuilder.Entity("HoraExtraWebApMVC.Models.HorasExtra", b =>
                {
                    b.HasOne("HoraExtraWebApMVC.Models.Funcionario", "Funcionario")
                        .WithMany("HorasExtra")
                        .HasForeignKey("FuncionarioId");
                });
#pragma warning restore 612, 618
        }
    }
}