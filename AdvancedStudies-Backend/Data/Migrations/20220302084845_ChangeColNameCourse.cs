using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvancedStudies_Backend.Migrations
{
    public partial class ChangeColNameCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05700c61-9ca9-4b3b-af49-c3cd4fff5611");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67a9fea8-620c-4a8f-9513-89146c4dea95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9a70ad8-c8b5-41fb-b71f-60714a34ae22");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Course",
                newName: "PublishedAt");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "128aaf32-21f4-4b96-be8e-a2c12a641e93", "cb3274ef-74a3-4d9d-92ba-9a4f74f37921", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "220e6f88-42a0-4404-bdb5-9eb305fba9c3", "fd04159a-a74f-480b-821d-0bed9e30c575", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c08c970d-338a-4f76-be8e-9cfcdeb6d71f", "bd3d9514-50dd-407e-a42a-79ce67a37f80", "Student", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "128aaf32-21f4-4b96-be8e-a2c12a641e93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "220e6f88-42a0-4404-bdb5-9eb305fba9c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c08c970d-338a-4f76-be8e-9cfcdeb6d71f");

            migrationBuilder.RenameColumn(
                name: "PublishedAt",
                table: "Course",
                newName: "CreatedAt");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05700c61-9ca9-4b3b-af49-c3cd4fff5611", "2397e015-e9dc-4f6b-8078-f2e1a3958737", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67a9fea8-620c-4a8f-9513-89146c4dea95", "fa8af45c-1680-4fa2-a862-3cc844a83454", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9a70ad8-c8b5-41fb-b71f-60714a34ae22", "dac93905-b81e-4abd-890a-02930238f76c", "Teacher", "TEACHER" });
        }
    }
}
