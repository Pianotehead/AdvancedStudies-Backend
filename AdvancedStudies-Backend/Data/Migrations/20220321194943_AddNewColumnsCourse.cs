using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvancedStudies_Backend.Migrations
{
    public partial class AddNewColumnsCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Course",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CongratulationsMessage",
                table: "Course",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Course",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WelcomeMessage",
                table: "Course",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b545955a-072b-49f9-ae00-e702fa668022", "6ef3b6f4-1a70-4bab-bee5-63fa3efdd590", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfa17b9c-a7fe-4bce-ae8c-2efe88717b15", "2fe73068-cc0b-4183-8f48-e840f3d2d81c", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dac3d640-b96a-4b9c-9565-3ef5954d695e", "7c0c5f17-b14e-450c-89a5-9ea01ad4cbd7", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b545955a-072b-49f9-ae00-e702fa668022");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfa17b9c-a7fe-4bce-ae8c-2efe88717b15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dac3d640-b96a-4b9c-9565-3ef5954d695e");

            migrationBuilder.DropColumn(
                name: "CongratulationsMessage",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "WelcomeMessage",
                table: "Course");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

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
    }
}
