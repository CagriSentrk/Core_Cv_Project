using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_updateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Adverts_AdvertAdver_Id",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Surnmae",
                table: "Users",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "AdvertAdver_Id",
                table: "Users",
                newName: "Advert_Id1");

            migrationBuilder.RenameColumn(
                name: "Adver_Id",
                table: "Users",
                newName: "Advert_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AdvertAdver_Id",
                table: "Users",
                newName: "IX_Users_Advert_Id1");

            migrationBuilder.RenameColumn(
                name: "Adver_Id",
                table: "Adverts",
                newName: "Advert_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Adverts_Advert_Id1",
                table: "Users",
                column: "Advert_Id1",
                principalTable: "Adverts",
                principalColumn: "Advert_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Adverts_Advert_Id1",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "Surnmae");

            migrationBuilder.RenameColumn(
                name: "Advert_Id1",
                table: "Users",
                newName: "AdvertAdver_Id");

            migrationBuilder.RenameColumn(
                name: "Advert_Id",
                table: "Users",
                newName: "Adver_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Advert_Id1",
                table: "Users",
                newName: "IX_Users_AdvertAdver_Id");

            migrationBuilder.RenameColumn(
                name: "Advert_Id",
                table: "Adverts",
                newName: "Adver_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Adverts_AdvertAdver_Id",
                table: "Users",
                column: "AdvertAdver_Id",
                principalTable: "Adverts",
                principalColumn: "Adver_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
