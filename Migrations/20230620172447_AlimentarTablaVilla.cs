using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "Equitación, cata de vinos", "Villa con viñedos en Touluse", new DateTime(2023, 6, 20, 11, 24, 47, 547, DateTimeKind.Local).AddTicks(5468), new DateTime(2023, 6, 20, 11, 24, 47, 547, DateTimeKind.Local).AddTicks(5455), "", 70.0, "Villa Francesa", 12, 500.0 },
                    { 2, "Nado en aguas heladas, bajo el cálido sol de la costa", "Villa con vista al cristalino mar", new DateTime(2023, 6, 20, 11, 24, 47, 547, DateTimeKind.Local).AddTicks(5471), new DateTime(2023, 6, 20, 11, 24, 47, 547, DateTimeKind.Local).AddTicks(5470), "", 40.0, "Villa Mediterranea", 8, 800.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
