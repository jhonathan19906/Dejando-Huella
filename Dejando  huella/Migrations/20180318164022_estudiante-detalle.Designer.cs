﻿
using EFCoreEjemplos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Instituto.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180318164022_estudiante-detalle")]
    partial class estudiantedetalle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreEjemplos.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("EFCoreEjemplos.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Calle");

                    b.Property<int>("EstudianteId");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId")
                        .IsUnique();

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("EFCoreEjemplos.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Edad");

                    b.Property<bool>("EstaBorrado");

                    b.Property<int>("InstitucionId");

                    b.Property<string>("Nombre")
                        .IsConcurrencyToken();

                    b.HasKey("Id");

                    b.HasIndex("InstitucionId");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("EFCoreEjemplos.EstudianteCurso", b =>
                {
                    b.Property<int>("CursoId");

                    b.Property<int>("EstudianteId");

                    b.Property<bool>("Activo");

                    b.HasKey("CursoId", "EstudianteId");

                    b.HasIndex("EstudianteId");

                    b.ToTable("EstudiantesCursos");
                });

            modelBuilder.Entity("EFCoreEjemplos.EstudianteDetalle", b =>
                {
                    b.Property<int>("Id");

                    b.Property<bool>("Becado");

                    b.Property<string>("Carrera");

                    b.Property<int>("CategoriaDePago");

                    b.HasKey("Id");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("EFCoreEjemplos.Institucion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Instituciones");
                });

            modelBuilder.Entity("EFCoreEjemplos.Direccion", b =>
                {
                    b.HasOne("EFCoreEjemplos.Estudiante")
                        .WithOne("Direccion")
                        .HasForeignKey("EFCoreEjemplos.Direccion", "EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCoreEjemplos.Estudiante", b =>
                {
                    b.HasOne("EFCoreEjemplos.Institucion")
                        .WithMany("Estudiantes")
                        .HasForeignKey("InstitucionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCoreEjemplos.EstudianteCurso", b =>
                {
                    b.HasOne("EFCoreEjemplos.Curso", "Curso")
                        .WithMany("EstudiantesCursos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFCoreEjemplos.Estudiante", "Estudiante")
                        .WithMany("EstudiantesCursos")
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCoreEjemplos.EstudianteDetalle", b =>
                {
                    b.HasOne("EFCoreEjemplos.Estudiante", "Estudiante")
                        .WithOne("Detalles")
                        .HasForeignKey("EFCoreEjemplos.EstudianteDetalle", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
