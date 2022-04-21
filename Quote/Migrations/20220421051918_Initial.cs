using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Quote.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quote = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Citation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 1, "Emily Bronte", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whatever our souls are made of, his and mine are the same.", "Love" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 2, "H. G. Wells", "H. G. Wells (1866-1946)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moral indignation is jealousy with a halo.", "Life" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 3, "Henry Davis", "Chessmaster Savielly Grigorievitch Tartakower (1887-1956)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victory goes to the player who makes the next-to-last mistake.", "Victory" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
