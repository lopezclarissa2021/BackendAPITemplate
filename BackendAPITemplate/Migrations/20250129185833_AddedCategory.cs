using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendAPITemplate.Migrations
{
    /// <inheritdoc />
    public partial class AddedCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "DynamicContent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CatergoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CatergoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DynamicContent_CategoryId",
                table: "DynamicContent",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_DynamicContent_Category_CategoryId",
                table: "DynamicContent",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CatergoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DynamicContent_Category_CategoryId",
                table: "DynamicContent");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_DynamicContent_CategoryId",
                table: "DynamicContent");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "DynamicContent");
        }
    }
}
