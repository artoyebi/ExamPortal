using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class changeTimeSpanToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cba5081-b26f-40c7-b255-54a29de4ce20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b187e78-87a8-49c1-9cad-8f5bd1365f7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "632719ca-460b-4943-854c-47552b3f7dda");

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tests",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53ac3b1b-6062-44eb-96ff-1588b6bfb668", "67834466-08be-414c-b521-fc1885e35a62", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de1791c1-146c-436c-9ea3-ddb159a1cf45", "35d79d1a-edd8-4922-aa7e-f274527974fc", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a184a55-db72-4c94-bb9a-ff4752dabb26", "23f9967b-19b3-4eaa-903f-1db388db5081", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a184a55-db72-4c94-bb9a-ff4752dabb26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53ac3b1b-6062-44eb-96ff-1588b6bfb668");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de1791c1-146c-436c-9ea3-ddb159a1cf45");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Tests",
                type: "time",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tests",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b187e78-87a8-49c1-9cad-8f5bd1365f7a", "c9f4299c-7feb-44e2-a397-77db7ad37fe3", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0cba5081-b26f-40c7-b255-54a29de4ce20", "9d74e666-38d9-4198-bd7b-4508ac5990ac", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "632719ca-460b-4943-854c-47552b3f7dda", "9de81533-5456-44dc-926e-809ca9358d5c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
