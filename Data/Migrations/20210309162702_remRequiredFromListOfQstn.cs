using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class remRequiredFromListOfQstn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d077bd8-88b9-4f9d-b4a8-759e122c94a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a96b782c-770e-4938-b63e-37b4e12ebd2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dba8b139-9485-4531-90de-ca2955bb4a71");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dba8b139-9485-4531-90de-ca2955bb4a71", "2dda92bc-6b28-42e6-8422-f2a5cc75d016", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d077bd8-88b9-4f9d-b4a8-759e122c94a7", "22f41a37-b422-4d1a-937b-72d96bff2326", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a96b782c-770e-4938-b63e-37b4e12ebd2e", "b18ba239-6a10-448e-aef6-e794e51499c1", "Administrator", "ADMINISTRATOR" });
        }
    }
}
