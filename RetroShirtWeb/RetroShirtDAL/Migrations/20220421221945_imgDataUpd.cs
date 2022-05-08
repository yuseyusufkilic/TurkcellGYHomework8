using Microsoft.EntityFrameworkCore.Migrations;

namespace RetroShirtDAL.Migrations
{
    public partial class imgDataUpd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Name", "Price", "TeamId" },
                values: new object[] { 2, "Fenerbahce short.", "FenerbahceShort", 100.0, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedTime", "Description", "Discount", "ImageUrl", "ModifiedDate", "Name", "Price", "TeamId" },
                values: new object[,]
                {
                    { 5, 2, null, "Real Madrid short.", null, "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg", null, "RMAShort", 250.0, 4 },
                    { 6, 1, null, "Barcelona top jersey.", null, "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg", null, "BarcelonaTop", 750.0, 2 },
                    { 7, 2, null, "Arsenal short.", null, "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg", null, "ArsenalShort", 150.0, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Name", "Price", "TeamId" },
                values: new object[] { 4, "Real Madrid boots.", "RMABoots", 750.0, 4 });
        }
    }
}
