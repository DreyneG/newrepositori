﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using newapi___Copia.Context;

#nullable disable

namespace newapiCopia.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("newapi___Copia.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("FuncionarioId"));

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("Setorid")
                        .HasColumnType("integer");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("Setorid");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("newapi___Copia.Models.Setor", b =>
                {
                    b.Property<int>("Setorid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Setorid"));

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Setorid");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("newapi___Copia.Models.Funcionario", b =>
                {
                    b.HasOne("newapi___Copia.Models.Setor", "Setor")
                        .WithMany()
                        .HasForeignKey("Setorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Setor");
                });
#pragma warning restore 612, 618
        }
    }
}