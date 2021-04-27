using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class candidateInTestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CandidateInTests",
                columns: table => new
                {
                    CandidateId = table.Column<string>(nullable: true),
                    TestId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CandidateInTests_AspNetUsers_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CandidateInTests_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateInTests");

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
    }
}
