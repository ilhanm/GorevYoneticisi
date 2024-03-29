﻿// <auto-generated />
using System;
using GorevYoneticisi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GorevYoneticisi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GorevYoneticisi.Models.Gorev", b =>
                {
                    b.Property<int>("gorevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("baslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("bitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("gorevAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gorevTuru")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("gorevId");

                    b.ToTable("Gorev");
                });
#pragma warning restore 612, 618
        }
    }
}
