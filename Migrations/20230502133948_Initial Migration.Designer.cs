﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using stacktimm.Data;

#nullable disable

namespace stacktimm.Migrations
{
    [DbContext(typeof(stacktimmDbContext))]
    [Migration("20230502133948_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("stacktimm.Models.Domain.Connaissance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodeCategorie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeConnaissance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Connaissances");
                });

            modelBuilder.Entity("stacktimm.Models.Domain.Ressource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodeConnaissance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeRessource")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeTypeRessource")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ressources");
                });
#pragma warning restore 612, 618
        }
    }
}