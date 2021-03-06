﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataProvider.SqlServer.Migrations
{
    [DbContext(typeof(MsSqlServerDb))]
    class MsSqlServerDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataProvider.Entities.Permiso", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("ApellidosEmpleado")
                    .IsRequired()
                    .HasColumnType("nvarchar(100)")
                    .HasMaxLength(100);

                b.Property<DateTime>("FechaPermiso")
                    .HasColumnType("datetime2");

                b.Property<string>("NombreEmpleado")
                    .IsRequired()
                    .HasColumnType("nvarchar(100)")
                    .HasMaxLength(100);

                b.Property<short>("TipoPermisoId")
                    .HasColumnType("smallint");

                b.HasKey("Id");

                b.ToTable("Permiso");
            });

            modelBuilder.Entity("DataProvider.Entities.TipoPermiso", b =>
            {
                b.Property<short>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("smallint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Descripcion")
                    .IsRequired()
                    .HasColumnType("nvarchar(100)")
                    .HasMaxLength(100);

                b.HasKey("Id");

                b.ToTable("TipoPermiso");

                b.HasData(
                    new
                    {
                        Id = (short) 1,
                        Descripcion = "Enfermedad"
                    },
                    new
                    {
                        Id = (short) 2,
                        Descripcion = "Diligencias"
                    });
            });

            modelBuilder.Entity("DataProvider.Entities.Permiso", b =>
            {
                b.HasOne("DataProvider.Entities.TipoPermiso", "TipoPermiso")
                    .WithMany("Permisos")
                    .HasForeignKey("TipoPermisoId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}