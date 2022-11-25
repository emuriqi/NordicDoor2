﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NordicDoorWeb.Data;

#nullable disable

namespace NordicDoorWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221124142655_AddForslagToDb")]
    partial class AddForslagToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NordicDoor.Models.ForslagModel", b =>
                {
                    b.Property<int>("ForslagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ForslagID"));

                    b.Property<int>("AnsattID")
                        .HasColumnType("int");

                    b.Property<string>("Ansavarlig")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatoRegistrert")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Frist")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Løsning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mål")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NyttForslag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Team")
                        .HasColumnType("int");

                    b.Property<string>("Tittel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Årsak")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ForslagID");

                    b.ToTable("Forslags");
                });

            modelBuilder.Entity("NordicDoorWeb.Models.AnsattModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Etternavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fornavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rolle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Team")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ansatte");
                });
#pragma warning restore 612, 618
        }
    }
}