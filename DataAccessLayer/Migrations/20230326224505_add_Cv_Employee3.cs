using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_Cv_Employee3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs_Job_Id1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Job_Id1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Job_Id1",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "Job_Id",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs_Job_Id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Job_Id",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "Job_Id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Job_Id1",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Job_Id1",
                table: "Employees",
                column: "Job_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs_Job_Id1",
                table: "Employees",
                column: "Job_Id1",
                principalTable: "Jobs",
                principalColumn: "Job_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
