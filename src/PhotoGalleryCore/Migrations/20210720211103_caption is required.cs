using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhotoGalleryCore.Migrations
{
    public partial class captionisrequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "Photos",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 1,
                columns: new[] { "Caption", "Date", "Description" },
                values: new object[] { "صورة 1", new DateTime(2021, 7, 21, 0, 11, 2, 752, DateTimeKind.Local).AddTicks(2309), "أبنية" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 2,
                columns: new[] { "Caption", "Description" },
                values: new object[] { "صورة 2", "مصورة تحمل الكاميرة" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 3,
                column: "Caption",
                value: "مدينة");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 4,
                column: "Caption",
                value: "شقة");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "Photos",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 1,
                columns: new[] { "Caption", "Date", "Description" },
                values: new object[] { null, new DateTime(2021, 7, 20, 22, 42, 48, 267, DateTimeKind.Local).AddTicks(6529), "صورة 1" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 2,
                columns: new[] { "Caption", "Description" },
                values: new object[] { null, "صورة 2" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 3,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 4,
                column: "Caption",
                value: null);
        }
    }
}
