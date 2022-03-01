using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvancedStudies_Backend.Migrations
{
    public partial class UpdateUserModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50ce0ea7-1b9d-49b3-b874-fe456ed6b96b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83abf3d2-5650-4657-af14-5a650070122f");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c7a69a0-420e-464a-8e5b-df3405ddab81", "aee536d3-72d8-4de3-a586-1e9919174d0d", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b1fa393-fe55-409e-bad6-1b1ead6d874b", "3757bf6d-7b32-4073-a612-fe8143338432", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "950d019d-e8f2-4e17-814c-11a9d03bff5d", "ca2949a1-9abd-4984-b3ee-e8cd81dcc0ce", "Teacher", "TEACHER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c7a69a0-420e-464a-8e5b-df3405ddab81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b1fa393-fe55-409e-bad6-1b1ead6d874b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "950d019d-e8f2-4e17-814c-11a9d03bff5d");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50ce0ea7-1b9d-49b3-b874-fe456ed6b96b", "a8e2ad50-018e-4133-a68e-a6a209cd399b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83abf3d2-5650-4657-af14-5a650070122f", "1055b304-f747-4304-bfee-5a456de1f08b", "Student", "STUDENT" });
        }
    }
}
