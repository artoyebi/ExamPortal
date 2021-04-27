using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class addKeyToCandidateInTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "CandidateInTests",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateInTests",
                table: "CandidateInTests",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateInTests",
                table: "CandidateInTests");

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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CandidateInTests");

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
    }
}
