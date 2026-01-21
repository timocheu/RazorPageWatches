using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorPageWatches.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Watch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watch", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Watch",
                columns: new[] { "Id", "Brand", "Model", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Rolex", "Watchless", 4223m, new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(493) },
                    { 2, "Omega", "Timekeeper", 5599m, new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(503) },
                    { 3, "Tag Heuer", "ChronoMaster", 3150m, new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(505) },
                    { 4, "Omega", "Aqua Terra", 4975m, new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(506) },
                    { 5, "Rolex", "Explorer", 7800m, new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(507) },
                    { 6, "Omega", "Speedmaster", 5500m, new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(508) },
                    { 7, "Rolex", "Submariner", 9400m, new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(509) },
                    { 8, "Tag Heuer", "Carrera", 4200m, new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(510) },
                    { 9, "Omega", "Seamaster", 3800m, new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(511) },
                    { 10, "Rolex", "Daytona", 13500m, new DateTime(2026, 1, 21, 12, 52, 46, 693, DateTimeKind.Local).AddTicks(512) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Watch");
        }
    }
}
