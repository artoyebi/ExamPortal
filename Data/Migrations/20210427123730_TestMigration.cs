using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "CandidateTestResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CandidateId = table.Column<string>(nullable: true),
                    TestId = table.Column<Guid>(nullable: false),
                    TotalScore = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateTestResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlaggedQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CandidateId = table.Column<string>(nullable: true),
                    QuestionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlaggedQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateChoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CandidateId = table.Column<string>(nullable: true),
                    QuestionId = table.Column<Guid>(nullable: false),
                    Choice = table.Column<string>(nullable: true),
                    MarkObtained = table.Column<double>(nullable: false),
                    CandidateTestResultId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateChoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandidateChoices_CandidateTestResults_CandidateTestResultId",
                        column: x => x.CandidateTestResultId,
                        principalTable: "CandidateTestResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d91d79ed-ea8e-4697-b8a1-0180b4e32658", "67b042b3-21cd-4a77-abdc-736996f708ca", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "714e719e-d57f-4a8f-83b4-8cc78f6a34dd", "c4495c82-c387-438c-93ed-6cafae882148", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "154e993b-db1e-420d-9273-b39b932da283", "c4e39b57-c543-4644-9a5d-4b2d67bd7347", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateChoices_CandidateTestResultId",
                table: "CandidateChoices",
                column: "CandidateTestResultId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateChoices");

            migrationBuilder.DropTable(
                name: "FlaggedQuestions");

            migrationBuilder.DropTable(
                name: "CandidateTestResults");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "154e993b-db1e-420d-9273-b39b932da283");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "714e719e-d57f-4a8f-83b4-8cc78f6a34dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d91d79ed-ea8e-4697-b8a1-0180b4e32658");

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
        }
    }
}
