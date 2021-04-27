using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class removeTracking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "4c2eb893-7ff7-492f-80b8-84951a73fe28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c3197ac-4a4d-4739-a479-c1a801b5492b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bd0b152-6a95-4104-a0ec-13e5b98476de");

            migrationBuilder.AlterColumn<string>(
                name: "CandidateId",
                table: "CandidateInTests",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b1cda2d-95bb-44c7-8019-03fbf86d9cb0", "58158590-2504-4c7d-aa33-0cc041ff23dc", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2bee34f5-09d5-4fd3-9b6b-d755aea7e12e", "6eb4db67-a4d6-4484-ada0-58948c20c892", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e398e02-d3d4-4986-acab-e2ad3d2f6876", "c95580c2-77b2-451e-b648-5e3a27ee655f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e398e02-d3d4-4986-acab-e2ad3d2f6876");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bee34f5-09d5-4fd3-9b6b-d755aea7e12e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b1cda2d-95bb-44c7-8019-03fbf86d9cb0");

            migrationBuilder.AlterColumn<string>(
                name: "CandidateId",
                table: "CandidateInTests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8bd0b152-6a95-4104-a0ec-13e5b98476de", "9be1825e-2d96-448d-ba15-4919de311de5", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c3197ac-4a4d-4739-a479-c1a801b5492b", "e445a212-40be-47fa-b6c8-c8003b7dd5c3", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c2eb893-7ff7-492f-80b8-84951a73fe28", "f1f9d39e-9797-455e-82b6-e4771262919e", "Administrator", "ADMINISTRATOR" });

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
    }
}
