using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment._18.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "ParentId" },
                values: new object[] { 1, null, "Programming", null });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "EmailAddress", "FullName" },
                values: new object[,]
                {
                    { 1, null, "Ahmad77@gmail.com", "Ahmad Gamal" },
                    { 2, null, "Salma66@gmail.com", "Salma Mostafa" },
                    { 3, null, "Omar98@gmail.com", "Omar Waleed" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "ParentId" },
                values: new object[,]
                {
                    { 2, null, "Back-End", 1 },
                    { 3, null, "Front-End", 1 },
                    { 4, null, "ASP.NET", 2 },
                    { 5, null, "Node.js", 2 },
                    { 6, null, "React", 3 },
                    { 7, null, "Angular", 3 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "Flag", "InstructorId", "Level", "Price", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, 4, null, true, 1, "Beginner", 8000m, null, "ASP-NET-G01" },
                    { 2, 4, null, false, 1, "Intermediate", 8000m, null, "ASP-NET-G02" },
                    { 3, 5, null, true, 2, "Beginner", 8000m, null, "NODE-JS-G01" },
                    { 4, 5, null, false, 2, "Intermediate", 8000m, null, "NODE-JS-G02" },
                    { 5, 6, null, true, 3, "Beginner", 8000m, null, "REACT-G01" },
                    { 6, 7, null, true, 3, "Advanced", 8000m, null, "ANGULAR-G01" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
