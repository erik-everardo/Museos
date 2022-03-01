﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Museos;

#nullable disable

namespace Museos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220301050822_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Museos.Tablas.Comentario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("ObraId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TextoContenido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UidVisitante")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Museos.Tablas.ComentarioMuseo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Calificacion")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("TextoContenido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UidVisitante")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ComentariosMuseos");
                });

            modelBuilder.Entity("Museos.Tablas.Obra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Detalles")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIncorporacion")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("FotoData")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Obras");
                });

            modelBuilder.Entity("Museos.Tablas.UsuarioAdmin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UsuariosAdmin");
                });

            modelBuilder.Entity("Museos.Tablas.Visitante", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Visitantes");
                });
#pragma warning restore 612, 618
        }
    }
}
