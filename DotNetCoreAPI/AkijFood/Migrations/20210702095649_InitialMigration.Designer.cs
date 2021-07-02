﻿// <auto-generated />
using CRUDoperation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AkijFood.Migrations
{
    [DbContext(typeof(dbAkijFoodDbContext))]
    [Migration("20210702095649_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUDoperation.tblColdDrinks", b =>
                {
                    b.Property<int>("intColdDrinksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("numQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("numUnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("strColdDrinksName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("intColdDrinksId");

                    b.ToTable("tblColdDrinks");
                });
#pragma warning restore 612, 618
        }
    }
}