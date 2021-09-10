using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class updatedseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "There's never been a better time to channel your inner Italian. Be sure to always use fresh herbs and GOOD EVOO.", new DateTime(2021, 9, 10, 11, 1, 53, 586, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2021, 9, 10, 11, 1, 53, 590, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "Hop on a train and get moving. Tis the season for a picturesque getaway.", new DateTime(2021, 9, 10, 11, 1, 53, 590, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Body", "PublishDate" },
                values: new object[] { "Tanzina Vega", "The canals of Venice provide a romantic way to travel through the city. Use the canals to visit a number of great restaurants.", new DateTime(2021, 9, 10, 11, 1, 53, 590, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Body", "PublishDate" },
                values: new object[] { "Eliza Moore", "Yola's new album provides rich sound and blissful lyrings.", new DateTime(2021, 9, 10, 11, 1, 53, 590, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "PublishDate" },
                values: new object[] { "Samantha Gomez", new DateTime(2021, 9, 10, 11, 1, 53, 590, DateTimeKind.Local).AddTicks(686) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "EVOO, Fresh herbs, and carbs.", new DateTime(2021, 8, 11, 12, 38, 22, 934, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2021, 8, 11, 12, 38, 22, 938, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PublishDate" },
                values: new object[] { "Hop on a train and get moving", new DateTime(2021, 8, 11, 12, 38, 22, 938, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Body", "PublishDate" },
                values: new object[] { "Tanzena Vega", "The canals do not smell and are great for long rides on a hot day", new DateTime(2021, 8, 11, 12, 38, 22, 938, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Body", "PublishDate" },
                values: new object[] { "Michelle Pfiefer", "Britney's new single is an offensively crafted BOP for the ages.", new DateTime(2021, 8, 11, 12, 38, 22, 938, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "PublishDate" },
                values: new object[] { "Gloria Estaban", new DateTime(2021, 8, 11, 12, 38, 22, 938, DateTimeKind.Local).AddTicks(2566) });
        }
    }
}
