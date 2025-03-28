﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonDB.Server.Data;

#nullable disable

namespace PersonDB.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220805175709_Seeding")]
    partial class Seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PersonDB.Shared.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 32,
                            Email = "peter.johns@gmail.com",
                            FirstName = "Peter",
                            Gender = 0,
                            LastName = "Johns",
                            PhoneNumber = "00312642236"
                        },
                        new
                        {
                            Id = 2,
                            Age = 28,
                            Email = "joe23@gmail.com",
                            FirstName = "Joe",
                            Gender = 0,
                            LastName = "Walsh",
                            PhoneNumber = "0048125629349"
                        },
                        new
                        {
                            Id = 3,
                            Age = 44,
                            Email = "Presidentpressoffice@apu.gov.ua",
                            FirstName = "Volodymyr",
                            Gender = 0,
                            LastName = "Zelensky",
                            PhoneNumber = "00380442841915"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
