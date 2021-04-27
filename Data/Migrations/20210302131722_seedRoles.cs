using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class seedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08478a0f-7785-458d-ad79-8e010919b517");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e35790e-609f-45a4-9f2a-77e6e97673aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f68d225-af89-4a3d-b94e-59740085f0b1");

            migrationBuilder.AlterColumn<string>(
                name: "Instruction",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b187e78-87a8-49c1-9cad-8f5bd1365f7a", "c9f4299c-7feb-44e2-a397-77db7ad37fe3", "Examiner", "EXAMINER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0cba5081-b26f-40c7-b255-54a29de4ce20", "9d74e666-38d9-4198-bd7b-4508ac5990ac", "Candidate", "CANDIDATE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "632719ca-460b-4943-854c-47552b3f7dda", "9de81533-5456-44dc-926e-809ca9358d5c", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cba5081-b26f-40c7-b255-54a29de4ce20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b187e78-87a8-49c1-9cad-8f5bd1365f7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "632719ca-460b-4943-854c-47552b3f7dda");

            migrationBuilder.AlterColumn<string>(
                name: "Instruction",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f68d225-af89-4a3d-b94e-59740085f0b1", "ad2b3363-c956-4b04-b5f5-8ceba186ae86", "Examiner", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e35790e-609f-45a4-9f2a-77e6e97673aa", "42a4b43a-6803-4edb-8c95-a398b7315fb7", "Candidate", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08478a0f-7785-458d-ad79-8e010919b517", "5bfb66f7-e882-42e2-862b-09d79e73f2d7", "Administrator", null });
        }
    }
}
