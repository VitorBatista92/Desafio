using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio.Data.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "titulos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroTitulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NomeDevedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CPFDevedor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PorcentagemJuros = table.Column<int>(type: "int", nullable: false),
                    PorcentagemMulta = table.Column<int>(type: "int", nullable: false),
                    ParcelaDivida = table.Column<int>(type: "int", nullable: false),
                    NumeroDaParcela = table.Column<int>(type: "int", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorDaParcela = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_titulos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "titulos",
                columns: new[] { "Id", "CPFDevedor", "DataVencimento", "DateCreated", "DateUpdated", "IsDeleted", "NomeDevedor", "NumeroDaParcela", "NumeroTitulo", "ParcelaDivida", "PorcentagemJuros", "PorcentagemMulta", "ValorDaParcela" },
                values: new object[] { new Guid("4ff32602-b9cf-4ec6-965f-5335e03fd08a"), "00000000000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Devedor de teste", 0, "000001", 1, 5, 10, 100000 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "titulos");
        }
    }
}
