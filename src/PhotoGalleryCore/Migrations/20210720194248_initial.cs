using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhotoGalleryCore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Path = table.Column<string>(type: "TEXT", nullable: true),
                    Rating = table.Column<int>(type: "INTEGER", nullable: true),
                    Caption = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Content = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AuthorName = table.Column<string>(type: "TEXT", nullable: true),
                    PhotoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "PhotoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PhotoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                    table.ForeignKey(
                        name: "FK_Tags_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "PhotoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Caption", "Date", "Description", "Path", "Rating" },
                values: new object[] { 1, null, new DateTime(2021, 7, 20, 22, 42, 48, 267, DateTimeKind.Local).AddTicks(6529), "صورة 1", "gallery/1.png", 5 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Caption", "Date", "Description", "Path", "Rating" },
                values: new object[] { 2, null, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "صورة 2", "gallery/2.png", 5 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Caption", "Date", "Description", "Path", "Rating" },
                values: new object[] { 3, null, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "صورة 3", "gallery/3.png", 5 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Caption", "Date", "Description", "Path", "Rating" },
                values: new object[] { 4, null, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "صورة 4", "gallery/4.png", 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PhotoId",
                table: "Comments",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_PhotoId",
                table: "Tags",
                column: "PhotoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Photos");
        }
    }
}
