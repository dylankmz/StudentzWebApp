﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Studentz.Models.Data;

namespace Studentz.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201229161345_DbInitLocationPhoneAdded")]
    partial class DbInitLocationPhoneAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Studentz.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("houseNumber")
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("studentGender")
                        .HasColumnType("int");

                    b.Property<int>("zip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}
