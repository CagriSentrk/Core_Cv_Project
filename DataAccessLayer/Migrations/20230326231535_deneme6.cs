using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class deneme6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Job_Id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Job_Id",
                table: "Employees",
                column: "Job_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs_Job_Id",
                table: "Employees",
                column: "Job_Id",
                principalTable: "Jobs",
                principalColumn: "Job_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs_Job_Id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Job_Id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Job_Id",
                table: "Employees");
        }
    }
}
