using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PruductProductID",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PruductProductID",
                table: "Comments",
                column: "PruductProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Pruducts_PruductProductID",
                table: "Comments",
                column: "PruductProductID",
                principalTable: "Pruducts",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Pruducts_PruductProductID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PruductProductID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PruductProductID",
                table: "Comments");
        }
    }
}
