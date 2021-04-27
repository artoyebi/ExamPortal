using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class removedCandidateChoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CandidateChoice",
                table: "QuestionAndAnswers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b23a0e5-a261-41e4-86d2-0271e8db5cf6", "fef755fd-d1da-466d-b9d2-4955ce65881c", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aba43bd1-5779-4caa-b8d9-133fe45dd8e3", "2f0c4af5-dcfe-40bc-9afd-bc28f8db235b", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6f8618c-ae2d-493d-a3f7-8262c1cdd0ed", "9af4e352-305c-4cb1-9789-21a1bf9bd38d", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b23a0e5-a261-41e4-86d2-0271e8db5cf6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aba43bd1-5779-4caa-b8d9-133fe45dd8e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6f8618c-ae2d-493d-a3f7-8262c1cdd0ed");

            migrationBuilder.AddColumn<string>(
                name: "CandidateChoice",
                table: "QuestionAndAnswers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
