﻿// <auto-generated />
using System;
using DesafioTecnico.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesafioTecnico.Migrations
{
    [DbContext(typeof(DesafioTecnicoContext))]
    partial class DesafioTecnicoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DesafioTecnico.Model.Entities.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlockId")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlockId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("DesafioTecnico.Model.Entities.Block", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CondominiumId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CondominiumId");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("DesafioTecnico.Model.Entities.Condominium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SyndicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Condominiums");
                });

            modelBuilder.Entity("DesafioTecnico.Model.Entities.Resident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("DesafioTecnico.Model.Entities.Apartment", b =>
                {
                    b.HasOne("DesafioTecnico.Model.Entities.Block", "Block")
                        .WithMany("Apartments")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Block");
                });

            modelBuilder.Entity("DesafioTecnico.Model.Entities.Block", b =>
                {
                    b.HasOne("DesafioTecnico.Model.Entities.Condominium", "Condominium")
                        .WithMany("Blocks")
                        .HasForeignKey("CondominiumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Condominium");
                });

            modelBuilder.Entity("DesafioTecnico.Model.Entities.Resident", b =>
                {
                    b.HasOne("DesafioTecnico.Model.Entities.Apartment", "Apartment")
                        .WithMany("Residents")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("DesafioTecnico.Model.Entities.Apartment", b =>
                {
                    b.Navigation("Residents");
                });

            modelBuilder.Entity("DesafioTecnico.Model.Entities.Block", b =>
                {
                    b.Navigation("Apartments");
                });

            modelBuilder.Entity("DesafioTecnico.Model.Entities.Condominium", b =>
                {
                    b.Navigation("Blocks");
                });
#pragma warning restore 612, 618
        }
    }
}
