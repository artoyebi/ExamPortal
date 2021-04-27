using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class dkwhy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
