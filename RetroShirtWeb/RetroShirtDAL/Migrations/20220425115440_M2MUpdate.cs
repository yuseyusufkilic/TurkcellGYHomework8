using Microsoft.EntityFrameworkCore.Migrations;

namespace RetroShirtDAL.Migrations
{
    public partial class M2MUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Bayern Munchen" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedTime", "Description", "Discount", "ImageUrl", "ModifiedDate", "Name", "Price", "TeamId" },
                values: new object[] { 9, 4, null, "BayernMBoots", null, "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg", null, "BayernMBoots", 450.0, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
