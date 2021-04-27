using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamPortal.Data.Migrations
{
    public partial class TestMigrationtwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.AddColumn<string>(
                name: "DummyProp",
                table: "FlaggedQuestions",
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.DropColumn(
                name: "DummyProp",
                table: "FlaggedQuestions");

          
        }
    }
}
