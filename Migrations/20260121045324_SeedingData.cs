using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPageWatches.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 53, 23, 716, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 53, 23, 716, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 53, 23, 716, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 53, 23, 716, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 53, 23, 716, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 53, 23, 716, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 53, 23, 716, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 53, 23, 716, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 53, 23, 716, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 53, 23, 716, DateTimeKind.Local).AddTicks(4545));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(512));
        }
    }
}
