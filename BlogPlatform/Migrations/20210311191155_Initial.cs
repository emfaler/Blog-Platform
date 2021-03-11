﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class Initial : Migration
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
                columns: new[] { "Id", "Author", "Body", "CategoryId", "Title" },
                values: new object[] { 1, "Ina Garten", "EVOO, Fresh herbs, and carbs.", 1, "Italian 101" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "Title" },
                values: new object[] { 2, "Ira Glass", "So many new podcasts to listen. Here are our picks.", 2, "Podcast Mania" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "Title" },
                values: new object[] { 3, "Rick Steves", "Hop on a train and get moving", 3, "Norway In a Day" });

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
