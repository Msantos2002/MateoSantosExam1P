using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MateoSantosExam1P.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraBASE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MS_Cerveza",
                columns: table => new
                {
                    MS_CervezaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MS_CervezaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MS_CervezaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MS_Escarchada = table.Column<bool>(type: "bit", nullable: false),
                    MS_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MS_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MS_Cerveza", x => x.MS_CervezaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MS_Cerveza");
        }
    }
}
