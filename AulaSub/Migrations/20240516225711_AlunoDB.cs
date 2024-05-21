using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AulaSub.Migrations
{
    /// <inheritdoc />
    public partial class AlunoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    AlunoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estudante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DtNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Turma = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.AlunoID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");
        }
    }
}
