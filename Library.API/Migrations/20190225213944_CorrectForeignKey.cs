using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.API.Migrations
{
    public partial class CorrectForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Friends_FriendConnectionId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "FriendId",
                table: "Books");

            migrationBuilder.AlterColumn<Guid>(
                name: "FriendConnectionId",
                table: "Books",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Friends_FriendConnectionId",
                table: "Books",
                column: "FriendConnectionId",
                principalTable: "Friends",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Friends_FriendConnectionId",
                table: "Books");

            migrationBuilder.AlterColumn<Guid>(
                name: "FriendConnectionId",
                table: "Books",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "FriendId",
                table: "Books",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Friends_FriendConnectionId",
                table: "Books",
                column: "FriendConnectionId",
                principalTable: "Friends",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
