using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvancedStudies_Backend.Migrations
{
    public partial class AddCoursesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");

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
    }
}
