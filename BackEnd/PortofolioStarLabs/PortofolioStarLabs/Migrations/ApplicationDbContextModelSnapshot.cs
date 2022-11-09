﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortofolioStarLabs.Persistence;

#nullable disable

namespace PortofolioStarLabs.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PortofolioStarLabs.Models.Contact", b =>
                {
                    b.Property<int>("contactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("contactEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("contactMessage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("contactName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("contactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("PortofolioStarLabs.Models.Photo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("PortofolioStarLabs.Models.Project", b =>
                {
                    b.Property<int>("projectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PhotoNum")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("projectDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("projectSubTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("projectTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("projectId");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
