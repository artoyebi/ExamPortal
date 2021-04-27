using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class addOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2260cf9-a88c-4529-b499-89ba2ab40ca5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3bf4b94-77b9-420d-bdf7-8e7979923b4d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3705513-1701-4bd0-926f-2dd1bfbe8abc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a14356a9-0279-406e-924b-e2cb18e25989", "dca5be80-93c6-4531-a6c5-6962ff4805da", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c13134b-bba8-43f1-80c3-5a7877dd5cca", "670edb9f-5f22-49d7-8e36-779e81599f50", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab22e4d7-f63f-4ada-a566-f68ba8a0ea65", "fecf0d83-90d5-4f1f-b0df-4475149d589c", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c13134b-bba8-43f1-80c3-5a7877dd5cca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a14356a9-0279-406e-924b-e2cb18e25989");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab22e4d7-f63f-4ada-a566-f68ba8a0ea65");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2260cf9-a88c-4529-b499-89ba2ab40ca5", "b988f738-83ae-4f6f-8553-177d9ab196bd", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3bf4b94-77b9-420d-bdf7-8e7979923b4d", "231111a8-e979-4dab-99af-b724748f16d8", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3705513-1701-4bd0-926f-2dd1bfbe8abc", "1a898e5b-6446-4a42-828e-0b9f9899104c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
