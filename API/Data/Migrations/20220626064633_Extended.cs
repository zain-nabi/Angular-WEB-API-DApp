using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Extended : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Interests",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KnownAs",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastActive",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LookingFor",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    IsMain = table.Column<bool>(type: "INTEGER", nullable: false),
                    PublicId = table.Column<string>(type: "TEXT", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_ApplicationUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ApplicationUserId",
                table: "Photos",
                column: "ApplicationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropColumn(
                name: "City",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "Interests",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "KnownAs",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "LastActive",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "LookingFor",
                table: "ApplicationUsers");
        }
    }
}
