using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.API.Migrations
{
    public partial class Datetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Friends");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Friends",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Friends");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Friends",
                nullable: false,
                defaultValue: 0);
        }
    }
}
