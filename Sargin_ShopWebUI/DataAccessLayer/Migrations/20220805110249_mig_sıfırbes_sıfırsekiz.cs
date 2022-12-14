using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_sıfırbes_sıfırsekiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages2",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderID = table.Column<int>(nullable: true),
                    ReceiverID = table.Column<int>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    MessageDetails = table.Column<string>(nullable: true),
                    MessageDate = table.Column<DateTime>(nullable: false),
                    MessageStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages2", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Messages2_Advertisers_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "Advertisers",
                        principalColumn: "AdvertiserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages2_Advertisers_SenderID",
                        column: x => x.SenderID,
                        principalTable: "Advertisers",
                        principalColumn: "AdvertiserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_ReceiverID",
                table: "Messages2",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_SenderID",
                table: "Messages2",
                column: "SenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages2");
        }
    }
}
