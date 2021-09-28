using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class APIModelsPermisoContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoPermiso",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPermiso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoPermisoId = table.Column<short>(type: "smallint", nullable: false),
                    FechaPermiso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permiso_TipoPermiso_TipoPermisoId",
                        column: x => x.TipoPermisoId,
                        principalTable: "TipoPermiso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TipoPermiso",
                columns: new[] { "Id", "Descripcion" },
                values: new object[] { (short)1, "Enfermedad" });

            migrationBuilder.InsertData(
                table: "TipoPermiso",
                columns: new[] { "Id", "Descripcion" },
                values: new object[] { (short)2, "Diligencia" });

            migrationBuilder.InsertData(
                table: "TipoPermiso",
                columns: new[] { "Id", "Descripcion" },
                values: new object[] { (short)3, "Otros" });

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_TipoPermisoId",
                table: "Permiso",
                column: "TipoPermisoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "TipoPermiso");
        }
    }
}
