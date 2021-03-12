using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class moreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Italian Cooking 101");

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "Title" },
                values: new object[,]
                {
                    { 4, "Tanzena Vega", "The canals do not smell and are great for long rides on a hot day", 1, "Venice" },
                    { 5, "Michelle Pfiefer", "Britney's new single is an offensively crafted BOP for the ages.", 2, "New Music Friday" },
                    { 6, "Rick Steves", "Hop on a train and get moving", 3, "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Italian 101");
        }
    }
}
