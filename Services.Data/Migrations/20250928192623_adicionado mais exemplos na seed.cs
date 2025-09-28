using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Desafio.Data.Migrations
{
    /// <inheritdoc />
    public partial class adicionadomaisexemplosnaseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "titulos",
                columns: new[] { "Id", "CPFDevedor", "DataVencimento", "DateCreated", "DateUpdated", "IsDeleted", "NomeDevedor", "NumeroDaParcela", "NumeroTitulo", "ParcelaDivida", "PorcentagemJuros", "PorcentagemMulta", "ValorDaParcela" },
                values: new object[,]
                {
                    { new Guid("7bf008c7-58d2-4d9c-b14a-2809a9df9a80"), "00000000000", new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Devedor de teste 3", 0, "000003", 20, 3, 2, 40000 },
                    { new Guid("94f4d913-108b-4cb7-8d1e-f532c5ef3402"), "00000000000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Devedor de teste 2", 0, "000002", 2, 5, 7, 50000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "titulos",
                keyColumn: "Id",
                keyValue: new Guid("7bf008c7-58d2-4d9c-b14a-2809a9df9a80"));

            migrationBuilder.DeleteData(
                table: "titulos",
                keyColumn: "Id",
                keyValue: new Guid("94f4d913-108b-4cb7-8d1e-f532c5ef3402"));
        }
    }
}
