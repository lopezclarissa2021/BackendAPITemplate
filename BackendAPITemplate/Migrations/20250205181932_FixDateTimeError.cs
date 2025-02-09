using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPITemplate.Migrations
{
    /// <inheritdoc />
    public partial class FixDateTimeError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DynamicContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DynamicContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DynamicContent",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 58, 27, 670, DateTimeKind.Local).AddTicks(8607), new DateTime(2025, 2, 5, 9, 58, 27, 673, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "DynamicContent",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 58, 27, 673, DateTimeKind.Local).AddTicks(5438), new DateTime(2025, 2, 5, 9, 58, 27, 673, DateTimeKind.Local).AddTicks(5448) });
        }
    }
}
