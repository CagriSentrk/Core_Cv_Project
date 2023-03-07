using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Categories_CategoryId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "Surnmae");

            migrationBuilder.RenameColumn(
                name: "Experience",
                table: "Users",
                newName: "Adver_Id");

            migrationBuilder.RenameColumn(
                name: "Cv",
                table: "Users",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Users",
                newName: "AdvertAdver_Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CategoryId",
                table: "Users",
                newName: "IX_Users_AdvertAdver_Id");

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    About_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.About_Id);
                });

            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Adver_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Adver_Id);
                });

            migrationBuilder.CreateTable(
                name: "Bussinesses",
                columns: table => new
                {
                    Bussines_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bussinesses", x => x.Bussines_Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Contact_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Contact_Id);
                });

            migrationBuilder.CreateTable(
                name: "Highlihts",
                columns: table => new
                {
                    Highlihts_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Highlihts", x => x.Highlihts_Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Adverts_AdvertAdver_Id",
                table: "Users",
                column: "AdvertAdver_Id",
                principalTable: "Adverts",
                principalColumn: "Adver_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Adverts_AdvertAdver_Id",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.DropTable(
                name: "Bussinesses");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Highlihts");

            migrationBuilder.RenameColumn(
                name: "Surnmae",
                table: "Users",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Users",
                newName: "Cv");

            migrationBuilder.RenameColumn(
                name: "AdvertAdver_Id",
                table: "Users",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "Adver_Id",
                table: "Users",
                newName: "Experience");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AdvertAdver_Id",
                table: "Users",
                newName: "IX_Users_CategoryId");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Categories_CategoryId",
                table: "Users",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
