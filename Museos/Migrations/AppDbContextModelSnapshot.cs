// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Museos;

#nullable disable

namespace Museos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

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

            modelBuilder.Entity("Museos.Tablas.Museo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Coordenadas")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaFundacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Historia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Mapa")
                        .HasColumnType("BLOB");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Museos");
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

                    b.Property<string>("FotoData")
                        .IsRequired()
                        .HasColumnType("TEXT");

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
