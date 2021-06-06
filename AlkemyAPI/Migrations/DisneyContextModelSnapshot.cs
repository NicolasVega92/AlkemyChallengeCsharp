﻿// <auto-generated />
using System;
using AlkemyAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlkemyAPI.Migrations
{
    [DbContext(typeof(DisneyContext))]
    partial class DisneyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alkemy.Entities.Genero", b =>
                {
                    b.Property<int>("ID_GENERO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ID_PELICULA")
                        .HasColumnType("int");

                    b.Property<byte[]>("IMAGEN")
                        .HasColumnType("image");

                    b.Property<string>("NOMBRE")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("PeliculaID_PELICULA")
                        .HasColumnType("int");

                    b.HasKey("ID_GENERO");

                    b.HasIndex("PeliculaID_PELICULA");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Alkemy.Entities.Pelicula", b =>
                {
                    b.Property<int>("ID_PELICULA")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte?>("CALIFICACION")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("FECHA_CREACION")
                        .HasColumnType("datetime2");

                    b.Property<string>("TITULO")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("ID_PELICULA");

                    b.ToTable("Pelicula");
                });

            modelBuilder.Entity("Alkemy.Entities.Personaje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EDAD")
                        .HasColumnType("int");

                    b.Property<string>("HISTORIA")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("IMAGEN")
                        .HasColumnType("image");

                    b.Property<string>("NOMBRE")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("PESO")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Personaje");
                });

            modelBuilder.Entity("PeliculaPersonaje", b =>
                {
                    b.Property<int>("PeliculasID_PELICULA")
                        .HasColumnType("int");

                    b.Property<int>("PersonajesID")
                        .HasColumnType("int");

                    b.HasKey("PeliculasID_PELICULA", "PersonajesID");

                    b.HasIndex("PersonajesID");

                    b.ToTable("PeliculaPersonaje");
                });

            modelBuilder.Entity("Alkemy.Entities.Genero", b =>
                {
                    b.HasOne("Alkemy.Entities.Pelicula", "Pelicula")
                        .WithMany("Generoes")
                        .HasForeignKey("PeliculaID_PELICULA");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("PeliculaPersonaje", b =>
                {
                    b.HasOne("Alkemy.Entities.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasID_PELICULA")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Alkemy.Entities.Personaje", null)
                        .WithMany()
                        .HasForeignKey("PersonajesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Alkemy.Entities.Pelicula", b =>
                {
                    b.Navigation("Generoes");
                });
#pragma warning restore 612, 618
        }
    }
}