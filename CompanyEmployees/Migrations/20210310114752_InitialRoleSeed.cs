using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyEmployees.Migrations
{
    public partial class InitialRoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3aea1c6-f60a-4f5e-b6f8-a62b0bbb7b23", "d443d2ce-2b32-410b-96e6-1e4502df8840", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "659847e5-f599-4c8b-8bb2-f9b8983cd23d", "32558a44-096a-4f8f-beee-16afff193fd5", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "659847e5-f599-4c8b-8bb2-f9b8983cd23d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3aea1c6-f60a-4f5e-b6f8-a62b0bbb7b23");
        }
    }
}
