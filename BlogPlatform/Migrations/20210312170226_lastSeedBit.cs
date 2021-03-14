using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class lastSeedBit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Body", "Title" },
                values: new object[] { "Gloria Estaban", "You can go anywhere with these direct flights to top destinations.", "50 Direct Flights" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Body", "Title" },
                values: new object[] { "Rick Steves", "Hop on a train and get moving", "" });
        }
    }
}
