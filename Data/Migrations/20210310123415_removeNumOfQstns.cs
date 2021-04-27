using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class removeNumOfQstns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36ef4f82-2833-475d-b165-69af473eeae2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7221b83-5c85-4031-afd6-f68e31fc7840");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d09fd248-0226-42ed-978d-d19cee1e4b4c");

            migrationBuilder.DropColumn(
                name: "NumberofQstns",
                table: "Tests");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bdfbb8c3-f100-48eb-9aae-9608033f7d9f", "70175b03-e785-4e2a-92f8-a243afdfe082", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cde676a8-4f79-4359-aac9-5af1a93da1e9", "cbc4b117-bfed-447b-aeed-5d0406652eae", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d0656e1-7458-496e-b986-a96911dfca8a", "76d69b08-3a9c-4ae3-910d-0e668c1cacf0", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d0656e1-7458-496e-b986-a96911dfca8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdfbb8c3-f100-48eb-9aae-9608033f7d9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cde676a8-4f79-4359-aac9-5af1a93da1e9");

            migrationBuilder.AddColumn<int>(
                name: "NumberofQstns",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36ef4f82-2833-475d-b165-69af473eeae2", "22d0a81c-f8bd-49d7-9d00-1d32481ca94f", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7221b83-5c85-4031-afd6-f68e31fc7840", "04dd6778-1a39-4ffb-a78d-e9f6937f09ff", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d09fd248-0226-42ed-978d-d19cee1e4b4c", "8a8aaddc-3b2d-4cef-9e25-a2a803bc31e7", "Administrator", "ADMINISTRATOR" });
        }
    }
}
