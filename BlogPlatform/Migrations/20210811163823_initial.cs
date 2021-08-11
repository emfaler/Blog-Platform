using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Cooking" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Culture" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Travel" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Ina Garten", "EVOO, Fresh herbs, and carbs.", 1, new DateTime(2021, 8, 11, 12, 38, 22, 934, DateTimeKind.Local).AddTicks(7953), "Italian Cooking 101" },
                    { 4, "Tanzena Vega", "The canals do not smell and are great for long rides on a hot day", 1, new DateTime(2021, 8, 11, 12, 38, 22, 938, DateTimeKind.Local).AddTicks(2557), "Venice" },
                    { 2, "Ira Glass", "So many new podcasts to listen. Here are our picks.", 2, new DateTime(2021, 8, 11, 12, 38, 22, 938, DateTimeKind.Local).AddTicks(2502), "Podcast Mania" },
                    { 5, "Michelle Pfiefer", "Britney's new single is an offensively crafted BOP for the ages.", 2, new DateTime(2021, 8, 11, 12, 38, 22, 938, DateTimeKind.Local).AddTicks(2562), "New Music Friday" },
                    { 3, "Rick Steves", "Hop on a train and get moving", 3, new DateTime(2021, 8, 11, 12, 38, 22, 938, DateTimeKind.Local).AddTicks(2551), "Norway In a Day" },
                    { 6, "Gloria Estaban", "You can go anywhere with these direct flights to top destinations.", 3, new DateTime(2021, 8, 11, 12, 38, 22, 938, DateTimeKind.Local).AddTicks(2566), "50 Direct Flights" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CategoryId",
                table: "Contents",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
