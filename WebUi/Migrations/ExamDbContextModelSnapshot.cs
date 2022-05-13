﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebUi;

#nullable disable

namespace WebUi.Migrations
{
    [DbContext(typeof(ExamDbContext))]
    partial class ExamDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebUi.Models.Dresseur", b =>
                {
                    b.Property<int>("DresseurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Prénom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DresseurId");

                    b.ToTable("Dresseurs");
                });

            modelBuilder.Entity("WebUi.Models.Pokemon", b =>
                {
                    b.Property<int>("PokemonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DresseurID")
                        .HasColumnType("int");

                    b.Property<int>("Niveau")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("PokemonId");

                    b.HasIndex("DresseurID");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("WebUi.Models.Pokemon", b =>
                {
                    b.HasOne("WebUi.Models.Dresseur", "Dresseur")
                        .WithMany("Pokemons")
                        .HasForeignKey("DresseurID");

                    b.Navigation("Dresseur");
                });

            modelBuilder.Entity("WebUi.Models.Dresseur", b =>
                {
                    b.Navigation("Pokemons");
                });
#pragma warning restore 612, 618
        }
    }
}
