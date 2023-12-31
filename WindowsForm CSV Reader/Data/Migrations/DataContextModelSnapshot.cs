﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WindowsForm_CSV_Reader.Database;

#nullable disable

namespace WindowsForm_CSV_Reader.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WindowsForm_CSV_Reader.Models.DataModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EAN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ID_KARTOTEKI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JEDNOSTKA_MIARY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KOD_PRODUCENTA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MIN_ZAM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Main_Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAZWA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPIS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PRODUCENT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pictures")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STAN_NA_MAGAZYNIE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VAT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WAGA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
