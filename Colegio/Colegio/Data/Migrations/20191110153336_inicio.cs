using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Colegio.Data.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreadoEn = table.Column<DateTime>(nullable: false),
                    ModificadoEn = table.Column<DateTime>(nullable: false),
                    EliminadoEn = table.Column<DateTime>(nullable: false),
                    CreadoPor = table.Column<string>(nullable: true),
                    ModificadoPor = table.Column<string>(nullable: true),
                    EliminadoPor = table.Column<string>(nullable: true),
                    Activo = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Detalle = table.Column<string>(maxLength: 255, nullable: true),
                    Lugar = table.Column<string>(maxLength: 50, nullable: true),
                    Codigo = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreadoEn = table.Column<DateTime>(nullable: false),
                    ModificadoEn = table.Column<DateTime>(nullable: false),
                    EliminadoEn = table.Column<DateTime>(nullable: false),
                    CreadoPor = table.Column<string>(nullable: true),
                    ModificadoPor = table.Column<string>(nullable: true),
                    EliminadoPor = table.Column<string>(nullable: true),
                    Activo = table.Column<bool>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Detalles = table.Column<string>(nullable: true),
                    Codigo = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 50, nullable: true),
                    Cedula = table.Column<string>(maxLength: 20, nullable: true),
                    FechaNac = table.Column<DateTime>(nullable: false),
                    Nacionalidad = table.Column<string>(maxLength: 50, nullable: true),
                    Telefono = table.Column<string>(maxLength: 24, nullable: true),
                    Direccion = table.Column<string>(maxLength: 255, nullable: true),
                    Codigo = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(maxLength: 10, nullable: true),
                    Tutor = table.Column<string>(maxLength: 100, nullable: true),
                    Fechaingreso = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    PersonaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estudiantes_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelAcademico = table.Column<string>(maxLength: 50, nullable: true),
                    Sueldo = table.Column<decimal>(nullable: false),
                    PersonaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profesores_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_PersonaId",
                table: "Estudiantes",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_PersonaId",
                table: "Profesores",
                column: "PersonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
