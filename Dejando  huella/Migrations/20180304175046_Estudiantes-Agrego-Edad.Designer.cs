﻿// <auto-generated />
using EFCoreEjemplos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Instituto.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180304175046_Estudiantes-Agrego-Edad")]
    partial class EstudiantesAgregoEdad
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreEjemplos.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Edad");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Estudiantes");
                });
#pragma warning restore 612, 618
        }
    }
}