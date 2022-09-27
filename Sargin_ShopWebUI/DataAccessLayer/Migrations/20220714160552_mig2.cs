using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Pruducts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pruducts_CategoryID",
                table: "Pruducts",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pruducts_Categories_CategoryID",
                table: "Pruducts",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pruducts_Categories_CategoryID",
                table: "Pruducts");

            migrationBuilder.DropIndex(
                name: "IX_Pruducts_CategoryID",
                table: "Pruducts");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Pruducts");
        }
    }
}
