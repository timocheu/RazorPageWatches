using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPageWatches.Migrations
{
    /// <inheritdoc />
    public partial class IdentityPart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 13, 29, 26, 601, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 13, 29, 26, 601, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 13, 29, 26, 601, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 13, 29, 26, 601, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 13, 29, 26, 601, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 13, 29, 26, 601, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 13, 29, 26, 601, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 13, 29, 26, 601, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 13, 29, 26, 601, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 13, 29, 26, 601, DateTimeKind.Local).AddTicks(2044));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 12, 52, 59, 609, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 12, 52, 59, 609, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 12, 52, 59, 609, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 12, 52, 59, 609, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 12, 52, 59, 609, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 12, 52, 59, 609, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 12, 52, 59, 609, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 12, 52, 59, 609, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 12, 52, 59, 609, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2026, 2, 4, 12, 52, 59, 609, DateTimeKind.Local).AddTicks(9060));
        }
    }
}
