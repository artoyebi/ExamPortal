using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class addFKtoCIT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "CandidateId",
                table: "CandidateInTests",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aae732f1-0809-4aff-945c-db257f156cd0", "3baf7e3b-6ca1-4da7-8b8b-3b7a64b8503a", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e4c1d66-e42e-4099-88e0-b4edc3801eba", "f0d9c7ea-dd36-4f45-85d7-4d5a6b580911", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecafbaa5-d246-4804-9b80-4a9056eef9e1", "a51c7972-6d39-437e-b191-324cce09466a", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateInTests_CandidateId",
                table: "CandidateInTests",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateInTests_TestId",
                table: "CandidateInTests",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateInTests_AspNetUsers_CandidateId",
                table: "CandidateInTests",
                column: "CandidateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateInTests_Tests_TestId",
                table: "CandidateInTests",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateInTests_AspNetUsers_CandidateId",
                table: "CandidateInTests");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateInTests_Tests_TestId",
                table: "CandidateInTests");

            migrationBuilder.DropIndex(
                name: "IX_CandidateInTests_CandidateId",
                table: "CandidateInTests");

            migrationBuilder.DropIndex(
                name: "IX_CandidateInTests_TestId",
                table: "CandidateInTests");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e4c1d66-e42e-4099-88e0-b4edc3801eba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aae732f1-0809-4aff-945c-db257f156cd0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecafbaa5-d246-4804-9b80-4a9056eef9e1");

            migrationBuilder.AlterColumn<string>(
                name: "CandidateId",
                table: "CandidateInTests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
