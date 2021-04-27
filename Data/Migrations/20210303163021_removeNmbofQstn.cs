using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class removeNmbofQstn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72b45f26-aefc-4461-b1a3-4f38330efd66", "c62989bc-d988-4148-9c4b-3654e4d63e2e", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "250120a5-1181-4357-96dc-f50439763797", "18d66226-5b21-4a8f-94ef-e40028cf40bf", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2df60be8-f66f-4997-97a2-4dc763a1c9d3", "9a3678c2-5c81-4abd-9678-a5623235a6cb", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "250120a5-1181-4357-96dc-f50439763797");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2df60be8-f66f-4997-97a2-4dc763a1c9d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72b45f26-aefc-4461-b1a3-4f38330efd66");

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
    }
}
