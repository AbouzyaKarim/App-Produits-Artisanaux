﻿// <auto-generated />
using Artisanaux.Service.ProductAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Artisanaux.Service.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221208090623_remplirDB")]
    partial class remplirDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Artisanaux.Service.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduct"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("IdProduct");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            IdProduct = 1,
                            CategoryName = "Categorie1",
                            ImageURL = "https://artisanaka.blob.core.windows.net/artisana/1.jpg",
                            Price = 15.0,
                            ProductName = "Product1"
                        },
                        new
                        {
                            IdProduct = 2,
                            CategoryName = "Categorie2",
                            ImageURL = "https://artisanaka.blob.core.windows.net/artisana/2.jpg",
                            Price = 65.0,
                            ProductName = "Product2"
                        },
                        new
                        {
                            IdProduct = 3,
                            CategoryName = "Categorie3",
                            ImageURL = "https://artisanaka.blob.core.windows.net/artisana/3.jpg",
                            Price = 45.0,
                            ProductName = "Product3"
                        },
                        new
                        {
                            IdProduct = 4,
                            CategoryName = "Categorie4",
                            ImageURL = "https://artisanaka.blob.core.windows.net/artisana/4.jpg",
                            Price = 20.0,
                            ProductName = "Product4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
