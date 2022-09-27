using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_RE_diagram_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages2_AspNetUsers_AppUserId",
                table: "Messages2");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages2_AspNetUsers_AppUserId1",
                table: "Messages2");

            migrationBuilder.DropForeignKey(
                name: "FK_Pruducts_AspNetUsers_AppUsersId",
                table: "Pruducts");

            migrationBuilder.DropIndex(
                name: "IX_Pruducts_AppUsersId",
                table: "Pruducts");

            migrationBuilder.DropIndex(
                name: "IX_Messages2_AppUserId",
                table: "Messages2");

            migrationBuilder.DropIndex(
                name: "IX_Messages2_AppUserId1",
                table: "Messages2");

            migrationBuilder.DropColumn(
                name: "AppUsersId",
                table: "Pruducts");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Messages2");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Messages2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUsersId",
                table: "Pruducts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Messages2",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId1",
                table: "Messages2",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pruducts_AppUsersId",
                table: "Pruducts",
                column: "AppUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_AppUserId",
                table: "Messages2",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_AppUserId1",
                table: "Messages2",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages2_AspNetUsers_AppUserId",
                table: "Messages2",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages2_AspNetUsers_AppUserId1",
                table: "Messages2",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pruducts_AspNetUsers_AppUsersId",
                table: "Pruducts",
                column: "AppUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
