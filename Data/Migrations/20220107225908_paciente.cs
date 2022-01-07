using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAmb.Data.Migrations
{
    public partial class paciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    paciente_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false),
                    fechanacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genero_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.paciente_id);
                    table.ForeignKey(
                        name: "FK_Paciente_Genero_genero_id",
                        column: x => x.genero_id,
                        principalTable: "Genero",
                        principalColumn: "genero_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_genero_id",
                table: "Paciente",
                column: "genero_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
