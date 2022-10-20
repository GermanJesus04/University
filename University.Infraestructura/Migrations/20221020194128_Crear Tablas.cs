using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University.Infraestructura.Migrations
{
    public partial class CrearTablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 12, nullable: false),
                    NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    USUARIO_ACTUALIZACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    USUARIO_ELIMINACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FECHA_ELIMINACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: true),
                    ELIMINADO = table.Column<bool>(type: "bit", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CURSO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 12, nullable: false),
                    NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DESCRIPCION_CORTA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NIVEL = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    USUARIO_ACTUALIZACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    USUARIO_ELIMINACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FECHA_ELIMINACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: true),
                    ELIMINADO = table.Column<bool>(type: "bit", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CURSO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ESTUDIANTE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 12, nullable: false),
                    NOMBRE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    APELLIDO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHA_NACIMIENTO = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    USUARIO_ACTUALIZACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    USUARIO_ELIMINACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FECHA_ELIMINACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: true),
                    ELIMINADO = table.Column<bool>(type: "bit", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTUDIANTE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 12, nullable: false),
                    NOMBRE_USUARIO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    APELLIDO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CONTRASEÑA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    USUARIO_ACTUALIZACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    USUARIO_ELIMINACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FECHA_ELIMINACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: true),
                    ELIMINADO = table.Column<bool>(type: "bit", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaCurso",
                columns: table => new
                {
                    categoriasid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cursosid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaCurso", x => new { x.categoriasid, x.cursosid });
                    table.ForeignKey(
                        name: "FK_CategoriaCurso_CATEGORIA_categoriasid",
                        column: x => x.categoriasid,
                        principalTable: "CATEGORIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaCurso_CURSO_cursosid",
                        column: x => x.cursosid,
                        principalTable: "CURSO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TEMARIO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 12, nullable: false),
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    USUARIO_CREACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    USUARIO_ACTUALIZACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    USUARIO_ELIMINACION = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FECHA_ELIMINACION = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: true),
                    ELIMINADO = table.Column<bool>(type: "bit", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEMARIO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TEMARIO_CURSO_CursoId",
                        column: x => x.CursoId,
                        principalTable: "CURSO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursoEstudiante",
                columns: table => new
                {
                    cursosid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    estudiantesid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoEstudiante", x => new { x.cursosid, x.estudiantesid });
                    table.ForeignKey(
                        name: "FK_CursoEstudiante_CURSO_cursosid",
                        column: x => x.cursosid,
                        principalTable: "CURSO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursoEstudiante_ESTUDIANTE_estudiantesid",
                        column: x => x.estudiantesid,
                        principalTable: "ESTUDIANTE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaCurso_cursosid",
                table: "CategoriaCurso",
                column: "cursosid");

            migrationBuilder.CreateIndex(
                name: "IX_CursoEstudiante_estudiantesid",
                table: "CursoEstudiante",
                column: "estudiantesid");

            migrationBuilder.CreateIndex(
                name: "IX_TEMARIO_CursoId",
                table: "TEMARIO",
                column: "CursoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaCurso");

            migrationBuilder.DropTable(
                name: "CursoEstudiante");

            migrationBuilder.DropTable(
                name: "TEMARIO");

            migrationBuilder.DropTable(
                name: "USUARIO");

            migrationBuilder.DropTable(
                name: "CATEGORIA");

            migrationBuilder.DropTable(
                name: "ESTUDIANTE");

            migrationBuilder.DropTable(
                name: "CURSO");
        }
    }
}
