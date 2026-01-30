using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPageWatches.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingToWatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Watch",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Watch",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Watch",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 0m, new DateTime(2026, 1, 30, 13, 4, 20, 401, DateTimeKind.Local).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 0m, new DateTime(2026, 1, 30, 13, 4, 20, 401, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 0m, new DateTime(2026, 1, 30, 13, 4, 20, 401, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 0m, new DateTime(2026, 1, 30, 13, 4, 20, 401, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 0m, new DateTime(2026, 1, 30, 13, 4, 20, 401, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 0m, new DateTime(2026, 1, 30, 13, 4, 20, 401, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 0m, new DateTime(2026, 1, 30, 13, 4, 20, 401, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 0m, new DateTime(2026, 1, 30, 13, 4, 20, 401, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 0m, new DateTime(2026, 1, 30, 13, 4, 20, 401, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Watch",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 0m, new DateTime(2026, 1, 30, 13, 4, 20, 401, DateTimeKind.Local).AddTicks(8277) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Watch");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Watch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Watch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
    }
}
