using Microsoft.EntityFrameworkCore.Migrations;

namespace RetroShirtDAL.Migrations
{
    public partial class addmigrationdeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryTeams",
                columns: new[] { "CategoryId", "TeamId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "CategoryTeams",
                columns: new[] { "CategoryId", "TeamId" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryTeams",
                keyColumns: new[] { "CategoryId", "TeamId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryTeams",
                keyColumns: new[] { "CategoryId", "TeamId" },
                keyValues: new object[] { 2, 1 });
        }
    }
}
