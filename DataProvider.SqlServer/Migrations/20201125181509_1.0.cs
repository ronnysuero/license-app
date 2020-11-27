using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataProvider.SqlServer.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "TipoPermiso",
                table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_TipoPermiso", x => x.Id); });

            migrationBuilder.CreateTable(
                "Permiso",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(maxLength: 100, nullable: false),
                    ApellidosEmpleado = table.Column<string>(maxLength: 100, nullable: false),
                    TipoPermisoId = table.Column<short>(nullable: false),
                    FechaPermiso = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.Id);
                    table.ForeignKey(
                        "FK_Permiso_TipoPermiso_TipoPermisoId",
                        x => x.TipoPermisoId,
                        "TipoPermiso",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                "TipoPermiso",
                new[] {"Id", "Descripcion"},
                new object[] {(short) 1, "Enfermedad"});

            migrationBuilder.InsertData(
                "TipoPermiso",
                new[] {"Id", "Descripcion"},
                new object[] {(short) 2, "Diligencias"});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Permiso");

            migrationBuilder.DropTable(
                "TipoPermiso");
        }
    }
}